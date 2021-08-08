from typing import List

# O(n)_O(n)


def containsDuplicate(nums: List[int]) -> bool:
    nums_set = set(nums)
    return len(nums) != len(nums_set)
