# -*- coding: utf-8 -*-
"""
Created on Thu Jan 11 14:23:34 2018

@author: epowertheif
"""
import pygame 
import math
pygame.init()
white = (255,255,255)
black = (0,0,0)
red = (255,0,0)
green = (0,100,0)
lightgreen = (0,150,0)
lightred = (150,0,0)
blue = (0,0,255)
width = 1200
height = 650
smallfont = pygame.font.SysFont("Arial",25)
medfont = pygame.font.SysFont("Arial",25)
largefont = pygame.font.SysFont("Arial",80)
pygame.display.set_caption("Obstacle avoidance is slightly working")
gameDisplay = pygame.display.set_mode((width,height))
clock = pygame.time.Clock()
maxspeed = 50 #Max speed is 2 M/s
maxrotation = 90 #Tweak this
MaxSensor = 100 #10 Meter Range
FPS = 60
#SCALE IS EVERY 10 UNITS IS A METER

class NGVRobot(object):
    def __init__(self,sizex,sizey,posx,posy):
        self.sizex = sizex  #width of robot
        self.sizey = sizey #length of robot
        self.posx = posx  #position of middle of robot
        self.posy = posy #position of middle of robot
        self.vectorRotation = 0 
        self.vectorSpeed = 0
        self.angle = 0 #Heading of robot
        self.point1 = [posx+sizex/2,posy+sizey/2]#Points to create robot rectangle
        self.point2 = [posx+sizex/2,posy-sizey/2]
        self.point3 = [posx-sizex/2,posy+sizey/2]
        self.point4 = [posx-sizex/2,posy-sizey/2]
        self.Lidar = [posx,posy-sizey/2] #position of lidar
        self.LocalMinimaTime = 0 #Time in local minima
        self.LocalMinimaY = posy #Local minima estimated position
        self.LocalMinimaX = posx #Local minima estimated position 
    def Draw(self): #Draws robot
        pygame.draw.line(gameDisplay,black,self.point1,self.point2)
        pygame.draw.line(gameDisplay,black,self.point1,self.point3)
        pygame.draw.line(gameDisplay,black,self.point4,self.point2)
        pygame.draw.line(gameDisplay,black,self.point4,self.point3)
        pygame.draw.circle(gameDisplay,black,[int(self.Lidar[0]),int(self.Lidar[1])],2)
    def Rotate(self,angle): #Sets robots yaw
        self.angle = angle
        self.point1 = [self.posx+self.sizex/2,self.posy+self.sizey/2]
        self.point2 = [self.posx+self.sizex/2,self.posy-self.sizey/2]
        self.point3 = [self.posx-self.sizex/2,self.posy+self.sizey/2]
        self.point4 = [self.posx-self.sizex/2,self.posy-self.sizey/2]
        self.Lidar = [self.posx,self.posy-self.sizey/2]
        self.point1 = self.Spin(self.point1)
        self.point2 = self.Spin(self.point2)
        self.point3 = self.Spin(self.point3)
        self.point4 = self.Spin(self.point4)
        self.Lidar = self.Spin(self.Lidar)
    def Spin(self, point): #outputs a rotated point of robot around its middle
        sin = math.sin(self.angle * math.pi/180)
        cos = math.cos(self.angle * math.pi/180)
        point[0] -= self.posx
        point[1] -= self.posy
        newx = point[0] * cos - point[1] * sin
        newy = point[0] * sin + point[1] * cos
        point[0] = newx + self.posx 
        point[1] = newy + self.posy
        return point 
    def Speed(self): #outputs new position
        self.posx += self.speedvector * math.sin(self.angle * math.pi/180)
        self.posy -= self.speedvector * math.cos(self.angle * math.pi/180)
    def Movement(self,Vector):
        angleaddition  =  -self.angle + Vector[1] #approaches smallest angle
        self.speedvector = ((Vector[0] * math.sin(angleaddition*math.pi /180))/FPS) #speed of robot
        self.angle -= (maxrotation * math.cos(angleaddition * math.pi/180)) /FPS #changes robots heading
        self.angle = self.angle % 360
        self.Rotate(self.angle)
        self.Speed()
    def LocalMinimaDetect(self): #detects if robot has not moved more than a meter in 1.5 seconds
        MagnRobot = math.sqrt((self.posx-self.LocalMinimaX)**2 + (self.posy-self.LocalMinimaY)**2)
        if(MagnRobot < 10):
            self.LocalMinimaTime += 1
        else: 
            self.LocalMinimaTime = 0 
            self.LocalMinimaX = self.posx
            self.LocalMinimaY = self.posy 
        if(self.LocalMinimaTime > 90):
            return True
        else:
            return False 
        
    def WayPointVector(self,Target):#finds angle towards waypoint
        WayPointx = self.posx - Target.x
        WayPointy = self.posy - Target.y
        Magnitude = math.sqrt(WayPointx**2 + WayPointy**2)
        if(Magnitude > maxspeed):
            tempx = WayPointx/Magnitude
            tempy = WayPointy/Magnitude
            Magnitude = math.sqrt(tempx**2+tempy**2) * maxspeed
        angle = math.atan2(WayPointy,WayPointx) * 180 / math.pi
        return (Magnitude,angle)
    def LidarScan(self,ObstacleArray): #Outputs Lidar Scan 
        LidarScan = self.ProduceLidarPoints()
        ObstaclesDetectedPoints = []
        for Points in LidarScan:
            TempShortestMagnitude = []
            ShortestMagnitude =  MaxSensor + 1
            check = False
            for Obstacle in ObstacleArray:
                Rectangle = Obstacle.ClippingArea()
                TempLidar = cohensutherland(Rectangle[0], Rectangle[3], Rectangle[2], Rectangle[1], self.Lidar[0], self.Lidar[1], Points[0], Points[1])
                if(TempLidar == (None, None, None, None)):
                    continue
                Value1 = math.sqrt((TempLidar[0]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[1])**2)
                Value2 = math.sqrt((TempLidar[2]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[3])**2)
                if(Value1<Value2):
                    TempShortestMagnitude.append([TempLidar[0]-self.Lidar[0],self.Lidar[1] -TempLidar[1]])
                    pygame.draw.line(gameDisplay,red,self.Lidar,[TempLidar[0],TempLidar[1]])
                else:
                    TempShortestMagnitude.append([TempLidar[2]-self.Lidar[0],self.Lidar[1] -TempLidar[3]])
                check = True
            for Magnitude in TempShortestMagnitude:
                Temp = math.sqrt(Magnitude[0]**2 + Magnitude[1]**2)
                if(Temp < ShortestMagnitude):
                    ShortestReading = [Magnitude[0],Magnitude[1]]
                    ShortestMagnitude = Temp
            if(check):
                Magn = math.sqrt(ShortestReading[0]**2 + ShortestReading[1]**2)
                Angle = round((math.atan2(ShortestReading[1],ShortestReading[0])*180/math.pi + self.angle - 90)*-1,2) 
                if(Angle < -90):
                    Angle += 360
                if(Angle > 90):
                    Angle -= 360 
                ObstaclesDetectedPoints.append([Magn,Angle])
        return ObstaclesDetectedPoints
            
    def ProduceLidarPoints(self): #Produces Lidar Scan Points to be used for Lidar scan 
        #Edit If u want
        LidarAngle = -180## change to 270 full rnage 
        LidarPoints = []
        #Edit for Lidar Range
        InitialX = MaxSensor*math.cos((self.angle) *math.pi/180) + self.Lidar[0]## add 45 to angle full range
        InitialY = MaxSensor*math.sin((self.angle)* math.pi/180) + self.Lidar[1]## add 45 to angle full range
        while LidarAngle <= 0:
            X = (InitialX-self.Lidar[0])*math.cos(LidarAngle*math.pi/180) - (InitialY-self.Lidar[1]) * math.sin(LidarAngle*math.pi/180) + self.Lidar[0]
            Y = (InitialX - self.Lidar[0])*math.sin(LidarAngle*math.pi/180) + (InitialY - self.Lidar[1]) * math.cos(LidarAngle*math.pi/180) + self.Lidar[1]
            LidarPoints.append([X,Y])
            LidarAngle += .25
        for Points in LidarPoints:
            pygame.draw.circle(gameDisplay,black,[int(Points[0]),int(Points[1])],1)
        return LidarPoints
#class VectorAddingAvoidance(NGVRobot): #First Obstacle Avoidance implementation
#    def VectorAvoidance(self,ObstacleArray,Target):
#        LidarScan = self.LidarScanMaxDistance(ObstacleArray)
#        VectorAdd = [0,0]
#        #print(LidarScan)
#        #print(VectorAdd)
#        Gain = .05
#        WayPointGain = .2
#        for Points in LidarScan:
#            Vx = (Points[0] * math.cos(Points[1]*math.pi/180))
#            Vy = (Points[0] * math.sin(Points[1]*math.pi/180)) 
#            VectorAdd[0] += Vx * Gain
#            VectorAdd[1] += Vy * Gain 
#        WayPoint = self.WayPointVector(Target)
#        VectorAdd[0] = round(VectorAdd[0],0)
#        VectorAdd[1] = round(VectorAdd[1],0)
#        VectorAdd[0] += WayPoint[0] * math.cos(WayPoint[1]*math.pi/180) *WayPointGain
#        VectorAdd[1] += WayPoint[0] * math.sin(WayPoint[1]*math.pi/180)  *WayPointGain
#        Magn = math.sqrt(VectorAdd[0]**2+VectorAdd[1]**2)
#        VectorAdd[0] = VectorAdd[0]/Magn * maxspeed
#        VectorAdd[1] = VectorAdd[1]/Magn * maxspeed 
#        Magn = math.sqrt(VectorAdd[0]**2+VectorAdd[1]**2)
#        Angle = math.atan2(VectorAdd[1],VectorAdd[0]) * 180/ math.pi
#        return [Magn,Angle]
#        
#        
#    def LidarScanMaxDistance(self,ObstacleArray):
#        LidarScan = self.ProduceLidarPoints()
#        ObstaclesDetectedPoints = []
#        #CHECK EVERYTHING INCLUDE REFERENCE ANGLE IN THIS
#        for Points in LidarScan:
#            TempShortestMagnitude = []
#            ShortestMagnitude =  MaxSensor + 1
#            check = False
#            for Obstacle in ObstacleArray:
#                Rectangle = Obstacle.ClippingArea()
#                TempLidar = cohensutherland(Rectangle[0], Rectangle[3], Rectangle[2], Rectangle[1], self.Lidar[0], self.Lidar[1], Points[0], Points[1])
#                #print(TempLidar)
#                if(TempLidar == (None, None, None, None)):
#                    continue
#                Value1 = math.sqrt((TempLidar[0]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[1])**2)
#                Value2 = math.sqrt((TempLidar[2]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[3])**2)
#                if(Value1<Value2):
#                    TempShortestMagnitude.append([TempLidar[0]-self.Lidar[0],self.Lidar[1] -TempLidar[1]])
#                    pygame.draw.line(gameDisplay,red,self.Lidar,[TempLidar[0],TempLidar[1]])
#                else:
#                    TempShortestMagnitude.append([TempLidar[2]-self.Lidar[0],self.Lidar[1] -TempLidar[3]])
#                    #pygame.draw.line(gameDisplay,red,self.Lidar,[TempLidar[2],TempLidar[3]])
#                check = True
#            for Magnitude in TempShortestMagnitude:
#                Temp = math.sqrt(Magnitude[0]**2 + Magnitude[1]**2)
#                if(Temp < ShortestMagnitude):
#                    ShortestReading = [Magnitude[0],Magnitude[1]]
#                    ShortestMagnitude = Temp
#            if(check):
#                Magn = math.sqrt(ShortestReading[0]**2 + ShortestReading[1]**2) #HERE IS AN ISSUE LOOK HERE
#                Angle = round((math.atan2(ShortestReading[1],ShortestReading[0])*180/math.pi + self.angle - 90),2) 
#                if(Angle < -135):
#                    Angle += 360
#                if(Angle > 135): ###### IVE BEEN MESSING AROUND WITH THIS AREA CHECK IT
#                    Angle -= 360 
#                ObstaclesDetectedPoints.append([Magn,Angle])
#            else: # AND HERE #Issue is here i think #Its fixed weeee
#                W = round((math.atan2(self.Lidar[1]-Points[1],Points[0]-self.Lidar[0])*180/math.pi+self.angle - 90),2)
#                if(W < -135):
#                    W += 360
#                if(W > 135):
#                    W -= 360
#                ObstaclesDetectedPoints.append([MaxSensor,W])
#        LidarAngle1 = -179.75
#        while LidarAngle1 < -135:
#           ObstaclesDetectedPoints.append([MaxSensor,LidarAngle1])
#           LidarAngle1 += .25
#        LidarAngle1 = 135.25
#        while LidarAngle1 <= 180:
#            ObstaclesDetectedPoints.append([MaxSensor,LidarAngle1])
#            LidarAngle1 += .25
#        #print(ObstaclesDetectedPoints)
#        return ObstaclesDetectedPoints
class PotentialFieldAvoidance(NGVRobot): #Potential field algorithm
    def WayPointVector(self,Target): #Produces Way Point Vector No normilzation 
        WayPointx = self.posx - Target.x
        WayPointy = self.posy - Target.y
        Magnitude = math.sqrt(WayPointx**2 + WayPointy**2)
        angle = math.atan2(WayPointy,WayPointx) * 180 / math.pi
        return (Magnitude,angle)
    def PotentialFieldVector(self,ObstacleList,Target):   
        Alpha = 1 #Scaling factor
        AttractiveRadius = 0 #Radius robot stops
        SlowDownArea = 10 #Radius robot begins to slowdown 
        WayVect = self.WayPointVector(Target)
        AVector = [0,0] #Attractive Vector
        ObstacleVectors = self.LidarScan(ObstacleList)
        #Might Be UseLess
        if WayVect[0] < AttractiveRadius:
            AVector = [0,0]
        elif WayVect[0] >= AttractiveRadius and WayVect[0] <= SlowDownArea + AttractiveRadius:
            AVector[0] = Alpha*(WayVect[0] + AttractiveRadius)*math.cos(WayVect[1]*math.pi/180)
            AVector[1] = Alpha*(WayVect[0] + AttractiveRadius)*math.sin(WayVect[1]*math.pi/180)
        elif(WayVect[0] > SlowDownArea + AttractiveRadius):
            AVector[0] = Alpha*WayVect[0]*math.cos(WayVect[1]*math.pi/180)
            AVector[1] = Alpha*WayVect[0]*math.sin(WayVect[1]*math.pi/180)
        Magn1 = math.sqrt(AVector[0]**2 + AVector[1]**2)
        #print(AVector)
        if(Magn1 > 0): #Draws WayPoint Vector
            pygame.draw.line(gameDisplay,green,[self.posx,self.posy],[self.posx-AVector[0]/Magn1*maxspeed,self.posy-AVector[1]/Magn1*maxspeed])
        RVector = [0,0] #Initialize Repulsive Vector
        Beta = .01 #Scaling Vector
        ClosestRange = 10
        Spread = 40 #Range plus radius robot reacts to objects 
        for Obstacle in ObstacleVectors:
#            Obstacle[1] = (Obstacle[1] + self.angle+90) #Not Used Anymore 
#            if(Obstacle[1] > 360):
#                Obstacle[1] = Obstacle[1] - 360
#            elif(Obstacle[1] < -360):
#                Obstacle[1] = Obstacle[1] + 360
            if(Obstacle[0] < ClosestRange): #Closest Range Robot is allowed to approach obstacles
                RVector[0] -= 10**20*math.cos(Obstacle[1]*math.pi/180)
                RVector[1] -= 10**20*math.sin(Obstacle[1]*math.pi/180)
            elif ClosestRange <= Obstacle[0] and Obstacle[0] <= Spread + ClosestRange: #Potential Field Calculations
                RVector[0] -= Beta*((Spread+ClosestRange-Obstacle[0])**2)*math.cos((Obstacle[1])*math.pi/180)
                RVector[1] -= Beta*((Spread+ClosestRange-Obstacle[0])**2)*math.sin((Obstacle[1])*math.pi/180)
            else:
                pass
        RMagn = math.sqrt(RVector[0]**2 + RVector[1]**2)
        RAngle = math.atan2(RVector[1],RVector[0])*180/math.pi +self.angle + 90 #Shift Repulsive Vector based on heading 
        if(RAngle > 360):
            RAngle = RAngle - 360
        elif(RAngle < -360):
            RAngle = RAngle + 360
        RVector[0] = RMagn*math.cos(RAngle*math.pi/180) 
        RVector[1] = RMagn*math.sin(RAngle*math.pi/180)
        if(RMagn > 0): #Draw Avoidance Vector
            pygame.draw.line(gameDisplay,red,[self.posx,self.posy],[self.posx-RVector[0]/RMagn*maxspeed,self.posy-RVector[1]/RMagn*maxspeed])
        PotentialVectorxy = [AVector[0]+RVector[0],AVector[1]+RVector[1]]
        Magn = math.sqrt(PotentialVectorxy[0]**2 + PotentialVectorxy[1]**2)
        if(Magn > maxspeed):#Reduce magnitude to max speed
            PotentialVectorxy = [PotentialVectorxy[0]/Magn,PotentialVectorxy[1]/Magn] #Normalize
            Magn = math.sqrt(PotentialVectorxy[0]**2 + PotentialVectorxy[1]**2)*maxspeed
            pygame.draw.line(gameDisplay,blue,[self.posx,self.posy],[self.posx-PotentialVectorxy[0]*maxspeed,self.posy-PotentialVectorxy[1]*maxspeed])
        else:
            pygame.draw.line(gameDisplay,blue,[self.posx,self.posy],[self.posx-PotentialVectorxy[0]/Magn*maxspeed,self.posy-PotentialVectorxy[1]/Magn*maxspeed])
        Angle = math.atan2(PotentialVectorxy[1],PotentialVectorxy[0]) * 180/math.pi
        
        return [Magn,Angle]

class PotentialFieldVector2(PotentialFieldAvoidance):
    def Draw(self):
        pygame.draw.line(gameDisplay,blue,self.point1,self.point2)
        pygame.draw.line(gameDisplay,blue,self.point1,self.point3)
        pygame.draw.line(gameDisplay,blue,self.point4,self.point2)
        pygame.draw.line(gameDisplay,blue,self.point4,self.point3)
        pygame.draw.circle(gameDisplay,blue,[int(self.Lidar[0]),int(self.Lidar[1])],2)
    def PotentialFieldVector(self,ObstacleList,Target):   
        Alpha = 1
        AttractiveRadius = 0
        SlowDownArea = 10
        WayVect = self.WayPointVector(Target)
        AVector = [0,0]
        ObstacleVectors = self.LidarScan(ObstacleList)
        #Might Be UseLess
        if WayVect[0] < AttractiveRadius:
            AVector = [0,0]
        elif WayVect[0] >= AttractiveRadius and WayVect[0] <= SlowDownArea + AttractiveRadius:
            AVector[0] = Alpha*(WayVect[0] + AttractiveRadius)*math.cos(WayVect[1]*math.pi/180)
            AVector[1] = Alpha*(WayVect[0] + AttractiveRadius)*math.sin(WayVect[1]*math.pi/180)
        elif(WayVect[0] > SlowDownArea + AttractiveRadius):
            AVector[0] = Alpha*WayVect[0]*math.cos(WayVect[1]*math.pi/180)
            AVector[1] = Alpha*WayVect[0]*math.sin(WayVect[1]*math.pi/180)
        Magn1 = math.sqrt(AVector[0]**2 + AVector[1]**2)
        #print(AVector)
        if(Magn1 > 0):
            pygame.draw.line(gameDisplay,green,[self.posx,self.posy],[self.posx-AVector[0]/Magn1*maxspeed,self.posy-AVector[1]/Magn1*maxspeed])
        RVector = [0,0]
        #Beta = 1/(len(ObstacleVectors)+1) * 55
        Beta = .1
        ClosestRange = 10
        Spread = 40 #Range plus radius robot reacts to objects 
        #### Alot of editting needed 
        for Obstacle in ObstacleVectors:
            Obstacle[1] = (Obstacle[1] + self.angle+90) 
            if(Obstacle[1] > 360):
                Obstacle[1] = Obstacle[1] - 360
            elif(Obstacle[1] < -360):
                Obstacle[1] = Obstacle[1] + 360
            if(Obstacle[0] < ClosestRange):
                RVector[0] -= 10**20*math.cos(Obstacle[1]*math.pi/180)
                RVector[1] -= 10**20*math.sin(Obstacle[1]*math.pi/180)
                #print("1")
            elif ClosestRange <= Obstacle[0] and Obstacle[0] <= Spread + ClosestRange: #Something wrong with Y Vector due to Lidar input####
                Obstacle[0] = Obstacle[0]/100
                RMagn = Beta*((1/(Spread+ClosestRange))-1/(Obstacle[0]))*((1/Obstacle[0])**2)
                RAngle = Obstacle[1]
                RVector[0] += RMagn*math.cos(RAngle *math.pi/180)
                RVector[1] += RMagn*math.sin(RAngle*math.pi/180) 
            else:
                pass
        RMagn = math.sqrt(RVector[0]**2 + RVector[1]**2)
        if(RMagn > 0):
            pygame.draw.line(gameDisplay,red,[self.posx,self.posy],[self.posx-RVector[0]/RMagn*maxspeed,self.posy-RVector[1]/RMagn*maxspeed])
        PotentialVectorxy = [AVector[0]+RVector[0],AVector[1]+RVector[1]]
        Magn = math.sqrt(PotentialVectorxy[0]**2 + PotentialVectorxy[1]**2)
        if(Magn > maxspeed):
            PotentialVectorxy = [PotentialVectorxy[0]/Magn,PotentialVectorxy[1]/Magn] #Normalize
            Magn = math.sqrt(PotentialVectorxy[0]**2 + PotentialVectorxy[1]**2)*maxspeed
            pygame.draw.line(gameDisplay,blue,[self.posx,self.posy],[self.posx-PotentialVectorxy[0]*maxspeed,self.posy-PotentialVectorxy[1]*maxspeed])
        else:
            pygame.draw.line(gameDisplay,blue,[self.posx,self.posy],[self.posx-PotentialVectorxy[0]/Magn*maxspeed,self.posy-PotentialVectorxy[1]/Magn*maxspeed])
        Angle = math.atan2(PotentialVectorxy[1],PotentialVectorxy[0]) * 180/math.pi      
        return [Magn,Angle]
    
    
    
#class OldRobot(NGVRobot):
#    def LidarScan(self,ObstacleArray):
#        LidarScan = self.ProduceLidarPoints()
#        ObstaclesDetectedPoints = []
#        #CHECK EVERYTHING INCLUDE REFERENCE ANGLE IN THIS
#        for Points in LidarScan:
#            TempShortestMagnitude = []
#            ShortestMagnitude =  MaxSensor + 1
#            check = False
#            for Obstacle in ObstacleArray:
#                Rectangle = Obstacle.ClippingArea()
#                TempLidar = cohensutherland(Rectangle[0], Rectangle[3], Rectangle[2], Rectangle[1], self.Lidar[0], self.Lidar[1], Points[0], Points[1])
#                #print(TempLidar)
#                if(TempLidar == (None, None, None, None)):
#                    continue
#                Value1 = math.sqrt((TempLidar[0]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[1])**2)
#                Value2 = math.sqrt((TempLidar[2]-self.Lidar[0])**2 + (self.Lidar[1]-TempLidar[3])**2)
#                if(Value1<Value2):
#                    TempShortestMagnitude.append([TempLidar[0]-self.Lidar[0],self.Lidar[1] -TempLidar[1]])
#                    pygame.draw.line(gameDisplay,green,self.Lidar,[TempLidar[0],TempLidar[1]])
#                else:
#                    TempShortestMagnitude.append([TempLidar[2]-self.Lidar[0],self.Lidar[1] -TempLidar[3]])
#                    #pygame.draw.line(gameDisplay,red,self.Lidar,[TempLidar[2],TempLidar[3]])
#                check = True
#            for Magnitude in TempShortestMagnitude:
#                Temp = math.sqrt(Magnitude[0]**2 + Magnitude[1]**2)
#                if(Temp < ShortestMagnitude):
#                    ShortestReading = [Magnitude[0],Magnitude[1]]
#                    ShortestMagnitude = Temp
#            if(check):
#                Magn = math.sqrt(ShortestReading[0]**2 + ShortestReading[1]**2)
#                Angle = round((math.atan2(ShortestReading[1],ShortestReading[0])*180/math.pi + self.angle - 90)*-1,2) 
#                if(Angle < -135):
#                    Angle += 360
#                if(Angle > 135):
#                    Angle -= 360 
#                ObstaclesDetectedPoints.append([Magn,Angle])
#        return ObstaclesDetectedPoints
#    def OldAvoidance(self,ObstacleList):
#        front = False; 
#        left = False; 
#        right = False; 
#        closestLeft = MaxSensor
#        closestRight = MaxSensor
#        closestFront = MaxSensor
#        ObstacleVectors = self.LidarScan(ObstacleList)
#        for Obstacle in ObstacleVectors:
#            if Obstacle[1] > -45 and Obstacle[1] < 45:
#                front = True 
#                if(closestFront > Obstacle[0]):
#                    closestFront = Obstacle[0]
#            elif(Obstacle[1] < -45 and Obstacle[1] > -100):
#                right = True
#                if(closestRight > Obstacle[0]):
#                    closestRight = Obstacle[0]
#            elif(Obstacle[1] > 45 and Obstacle[1] < 100 ):
#                left = True
#                if(closestLeft > Obstacle[0]):
#                    closestLeft = Obstacle[0]
#        if front and left and right: 
#            return [1/min(closestFront,min(closestRight,closestLeft)),0]
#        elif front and left:
#            return [1/min(closestLeft,closestFront),45]
#        elif front and right: 
#            return [1/min(closestFront,closestRight),-45]
#        elif left and right: 
#            return [1/min(closestLeft,closestRight),180]
#        elif left:
#            return [1/closestLeft,90]
#        elif right:
#            return [1/closestRight,-90]
#        elif front: 
#            return [1/closestFront,0]
#        else:
#            return [0,180]
#    def Draw(self):
#        pygame.draw.line(gameDisplay,blue,self.point1,self.point2)
#        pygame.draw.line(gameDisplay,blue,self.point1,self.point3)
#        pygame.draw.line(gameDisplay,blue,self.point4,self.point2)
#        pygame.draw.line(gameDisplay,blue,self.point4,self.point3)
#        pygame.draw.circle(gameDisplay,blue,[int(self.Lidar[0]),int(self.Lidar[1])],2)
#    def AvoidanceVector(self,ObstacleList,goal):
#        WayPointVect = self.WayPointVector(goal)
#        AvoidanceVect = self.OldAvoidance(ObstacleList)
#        Alpha = 700
#        Beta = 1
#        ResultantVector = [0,0]
#        if (AvoidanceVect[0] > 0):
#            AVectx = AvoidanceVect[0]*math.cos(AvoidanceVect[1]*math.pi/180) * Alpha
#            AVecty = AvoidanceVect[0]*math.sin(AvoidanceVect[1]*math.pi/180) * Alpha
#            WVectx = WayPointVect[0]*math.cos(WayPointVect[1]*math.pi/180) * Beta
#            WVecty = WayPointVect[0]*math.sin(WayPointVect[1]*math.pi/180) * Beta
#            ResultantVecty = AVecty + WVecty 
#            ResultantVectx = AVectx + WVectx
#            Angle = math.atan2(ResultantVecty,ResultantVectx) * 180/math.pi
#            Magn = math.sqrt(ResultantVecty**2 + ResultantVectx**2)
#            ResultantVector = [Magn,Angle]
#        else:
#            ResultantVector = WayPointVect
#        return ResultantVector
#            
        
class Target(object):
    def __init__(self,posx,posy):
        self.x = posx
        self.y = posy
    def Draw(self):
        pygame.draw.circle(gameDisplay,green,[self.x,self.y],5)
        
class obstacle(object):
    def __init__(self,posx,posy,sizex,sizey):
        self.posx = posx
        self.posy = posy
        self.sizex = sizex
        self.sizey = sizey
    def Draw(self):
        pygame.draw.rect(gameDisplay,blue,[self.posx-self.sizex/2,self.posy-self.sizey/2,self.sizex,self.sizey],0)
    def ClippingArea(self):#For Lidar Scan algorithm
        xmin = self.posx - self.sizex/2
        ymax = self.posy - self.sizey/2
        xmax = self.posx + self.sizex/2
        ymin = self.posy + self.sizey/2
        return [xmin,ymax,xmax,ymin]

INSIDE,LEFT, RIGHT, LOWER, UPPER = 0,1, 2, 4, 8
    
def cohensutherland(xmin, ymax, xmax, ymin, x1, y1, x2, y2): #Line Clipping algorithm
    k1 = _getclip(x1, y1,xmin,xmax,ymin,ymax)
    k2 = _getclip(x2, y2,xmin,xmax,ymin,ymax)
    #examine non-trivially outside points
    #bitwise OR |
    while (k1 | k2) != 0: # if both points are inside box (0000) , ACCEPT trivial whole line in box

        # if line trivially outside window, REJECT
        if (k1 & k2) != 0: #bitwise AND &
            #if dbglvl>1: print('  REJECT trivially outside box')
            #return nan, nan, nan, nan
            return None, None, None, None

        #non-trivial case, at least one point outside window
        # this is not a bitwise or, it's the word "or"
        opt = k1 or k2 # take first non-zero point, short circuit logic
        if opt & UPPER: #these are bitwise ANDS
            x = x1 + (x2 - x1) * (ymax - y1) / (y2 - y1)
            y = ymax
        elif opt & LOWER:
            x = x1 + (x2 - x1) * (ymin - y1) / (y2 - y1)
            y = ymin
        elif opt & RIGHT:
            y = y1 + (y2 - y1) * (xmax - x1) / (x2 - x1)
            x = xmax
        elif opt & LEFT:
            y = y1 + (y2 - y1) * (xmin - x1) / (x2 - x1)
            x = xmin
        else:
            raise RuntimeError('Undefined clipping state')

        if opt == k1:
            x1, y1 = x, y
            k1 = _getclip(x1, y1,xmin,xmax,ymin,ymax)
            #if dbglvl>1: print('checking k1: ' + str(x) + ',' + str(y) + '    ' + str(k1))
        elif opt == k2:
            #if dbglvl>1: print('checking k2: ' + str(x) + ',' + str(y) + '    ' + str(k2))
            x2, y2 = x, y
            k2 = _getclip(x2, y2,xmin,xmax,ymin,ymax)
    return x1, y1, x2, y2
    
def _getclip(xa, ya,xmin,xmax,ymin,ymax):
        #if dbglvl>1: print('point: '),; print(xa,ya)
    p = INSIDE  #default is inside

        # consider x
    if xa < xmin:
        p |= LEFT
    elif xa > xmax:
        p |= RIGHT
        # consider y
    if ya < ymin:
        p |= LOWER # bitwise OR
    elif ya > ymax:
        p |= UPPER #bitwise OR
    return p
    
def text_objects(text, font):#Text display
    textSurface = font.render(text, True, black)
    return textSurface, textSurface.get_rect()
    
def message_display(text,x,y):#Text display
    TextSurf, TextRect = text_objects(text, medfont)
    TextRect.center = (x,y)
    gameDisplay.blit(TextSurf, TextRect)
    

    
def Loop():
    # 0-90 Degrees it to the right
    #-90 - 0 Degrees is to the left 
    robot = PotentialFieldAvoidance(10,30,100,300)#Robots
    #robot2 = PotentialFieldVector2(10,30,100,300)
    goal = Target(1000,450)
    obstacle1 = obstacle(500,350,2,50) #Obstacles
    obstacle2 = obstacle(800,350,30,30)
    obstacle3 = obstacle(350,250,20,20)
    obstacle4 = obstacle(310,330,20,20)
    obstacle5 = obstacle(825,400,30,30)
    obstacle6 = obstacle(750,450,20,20)
    obstacle7 = obstacle(700,475,20,20)
    obstacle8 = obstacle(450,270,20,20)
    obstacle9 = obstacle(500,300,20,20)
    robot.Rotate(0)
    #robot2.Rotate(0)
    ObstaclesList = [obstacle1,obstacle2,obstacle3,obstacle4,obstacle5,obstacle6,obstacle7,obstacle8,obstacle9] #Obstacle Array
    #ObstaclesList = [] #no obstacles
    print(robot.LidarScan(ObstaclesList))
    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
        gameDisplay.fill(white)
        robot.Movement(robot.PotentialFieldVector(ObstaclesList,goal))#Movement code
        robot.LocalMinimaDetect()
     #   robot2.Movement(robot2.PotentialFieldVector(ObstaclesList,goal))
        robot.Draw()
      #  robot2.Draw()
        for Obs in ObstaclesList:#Draws Obstacles
            Obs.Draw()
        goal.Draw()
        pygame.display.update()
        clock.tick(FPS)
Loop()
