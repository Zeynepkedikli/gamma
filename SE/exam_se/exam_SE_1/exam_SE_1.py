# test_divisible.py
import unittest
from divisible import divisible_by_3_or_5

class TestDivisibleBy3Or5(unittest.TestCase):

    def test_3(self):
        result = divisible_by_3_or_5(3)
        print(f"Test 3: divisible_by_3_or_5(3) => {result}")
        self.assertTrue(result)

    def test_5(self):
        result = divisible_by_3_or_5(5)
        print(f"Test 5: divisible_by_3_or_5(5) => {result}")
        self.assertTrue(result)

    def test_7(self):
        result = divisible_by_3_or_5(7)
        print(f"Test 7: divisible_by_3_or_5(7) => {result}")
        self.assertFalse(result)

    def test_15(self):
        result = divisible_by_3_or_5(15)
        print(f"Test 15: divisible_by_3_or_5(15) => {result}")
        self.assertTrue(result)

    def test_22(self):
        result = divisible_by_3_or_5(22)
        print(f"Test 22: divisible_by_3_or_5(22) => {result}")
        self.assertFalse(result)

if __name__ == '__main__':
    unittest.main()
