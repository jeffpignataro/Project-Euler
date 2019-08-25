def is_prime(n):
    return not any(n%i == 0 for i in range(2, n))