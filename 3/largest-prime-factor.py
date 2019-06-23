import math

num=600851475143

for i in range(1, num):
    if(num % i == 0):
        num=num/i        
        print(i)