from typing import List

# O(nlogn)_O(1)


def containsDuplicate(nums: List[int]) -> bool:
    nums.sort()
    for i in range(len(nums) - 1):
        if nums[i] == nums[i + 1]:
            return True
    return False
