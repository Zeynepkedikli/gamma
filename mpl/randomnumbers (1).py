import random 

meetings =[random.randint(1,10) for _ in range(4)]
print (meetings)
meetings.append(10)
print (meetings)
#------------------
total = 0 
total= sum(meetings)
print("avg numbers of people at meeting:" + str(round(total/len(meetings))))