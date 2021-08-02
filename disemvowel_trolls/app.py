import unittest

def disemvowel(string_: str) -> str:
    vowel_list = ["a", "e", "i", "o", "u"]
    result = ""
    for letter in string_:
        if letter.lower() not in vowel_list:
            result += letter
    return result


class MyTest(unittest.TestCase):
    def test(self):
        self.assertEqual(disemvowel("This website is for losers LOL!"), "Ths wbst s fr lsrs LL!")

unittest.main()
print(disemvowel("This website is for losers LOL!"))