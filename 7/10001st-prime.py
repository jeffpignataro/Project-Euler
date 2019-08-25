n=1000001
counter=1
for p in range(2, n+1):
    for i in range(2, p):
        if p % i == 0:
            break
    else:
        print ('{} {}'.format(counter, p))
        counter+=1
    if(counter==10003):
        break
print ('Done')