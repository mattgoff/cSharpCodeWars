import unittest

def sum_two_smallest_numbers(numbers: list) -> int:
    data = sorted(numbers)
    return data[0] + data[1]

class MyTestCases(unittest.TestCase):
  def test_one(self):
    self.assertEqual(sum_two_smallest_numbers([5, 8, 12, 18, 22]), 13)
    self.assertEqual(sum_two_smallest_numbers([7, 15, 12, 18, 22]), 19)
    self.assertEqual(sum_two_smallest_numbers([25, 42, 12, 18, 22]), 30)

unittest.main()
