


# okay what do we know 360 in a circle 
# so the we create a forumla of analog 12 




def timetoAngle(H,M):
   hours = (H*360) // 12 + (M*360) // (12 * 60)
   minutes  = (M  * 360) // 60
   getAngle = abs(hours - minutes)
   if getAngle > 180:
      getAngle = 360 - getAngle
   return getAngle



print(timetoAngle(5,30))
