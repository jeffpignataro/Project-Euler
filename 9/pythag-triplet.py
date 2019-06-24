import math
#a2+b2=c2
def isPythagTriplet(a,b,c):
    aSquare=math.pow(a,2)
    bSquare=math.pow(b,2)
    cSquare=math.pow(c,2)
    if(aSquare+bSquare==cSquare):
        return True
    return False
    
#a+b+c=1000
def equals1000(a,b,c):
    if(a+b+c==1000):
        return True
    return False

for a in range(1,500):
    for b in range(1,500):
        for c in range(1,500):
            if(isPythagTriplet(a,b,c) and equals1000(a,b,c)):
                print(f'A {a}, B {b}, C {c}')