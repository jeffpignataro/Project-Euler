import sys
import math

n = 2000000
total = counter = 0
for p in range(2, n+1):
    for i in range(2, int((math.sqrt(p))+1)):
        if p % i == 0:
            break
    else:
        counter += 1
        total += p
        print('{} {}'.format(counter, total))
print('Done')
