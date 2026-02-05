
def divisible_by_3_or_5(number):
    return number % 3 == 0 or number % 5 == 0


def test_divisible_by_3_or_5():
    test_cases = [3, 5, 7, 15, 22]  # 5 test cases
    expected_results = [True, True, False, True, False]

    for i, num in enumerate(test_cases):
        result = divisible_by_3_or_5(num)
        print(f"Test case {i+1}: divisible_by_3_or_5({num}) => {result} | Expected: {expected_results[i]} | {'PASS' if result == expected_results[i] else 'FAIL'}")


test_divisible_by_3_or_5()

