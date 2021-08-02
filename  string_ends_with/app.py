def solution(string: str, ending: str) -> bool:
    if string.endswith(ending):
        return True
    return False

print(solution('abc', 'bc')) # returns true
print(solution('abc', 'd')) # returns false

