num=600851475143
largest_divisor=0

for i in range(1, num):
    if(num % i == 0):
        largest_divisor=num

print(largest_divisor)