import unittest

def bmi(weight, height):
    bmi = weight / (height * height)
    if bmi > 30:
      return "Obese"
    if bmi >= 25:
      return "Overweight"
    if bmi >= 18.5:
      return "Normal"
    return "Underweight"

class MyTestClass(unittest.TestCase):
  def test(self):
    self.assertEqual(bmi(50, 1.80), "Underweight")
    self.assertEqual(bmi(80, 1.80), "Normal")
    self.assertEqual(bmi(90, 1.80), "Overweight")
    self.assertEqual(bmi(110, 1.80), "Obese")
    self.assertEqual(bmi(50, 1.50), "Normal")


unittest.main()