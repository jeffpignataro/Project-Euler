sums=0
sumofsquare=0
for i in range(1,101):
    square=i*i
    sumofsquare=sumofsquare+square
    sums=i+sums
squareofsums=sums*sums
print(squareofsums-sumofsquare)