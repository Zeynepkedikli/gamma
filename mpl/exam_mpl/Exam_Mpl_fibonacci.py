#prime sayı olup olmadığını kontrol ediyor
def is_prime(n):
    if n < 2:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

# Function to generate Fibonacci numbers less than a limit
def fibonacci_numbers(limit):
    fibs = [0, 1]
    while True:
        next_fib = fibs[-1] + fibs[-2]
        if next_fib >= limit:
            break
        fibs.append(next_fib)
    return fibs

# Main program
limit = 1000
fib_numbers = fibonacci_numbers(limit)
count = 0
prime_fib_numbers = []

for num in fib_numbers:
    if num > 0 and is_prime(num):
        prime_fib_numbers.append(num)
        count += 1

print(f"Prime Fibonacci numbers between 0 and {limit}: {prime_fib_numbers}")
print(f"Total count: {count}")
