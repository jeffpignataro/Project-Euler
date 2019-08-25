for a in range(100, 999):
    for b in range(100,999):
        possiblePalindrome=(str)(a*b)
        if(possiblePalindrome == possiblePalindrome[::-1]):
            print(possiblePalindrome)
