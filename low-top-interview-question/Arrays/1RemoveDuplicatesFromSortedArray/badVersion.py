from typing import List


def remove_duplicates1(nums: List[int]) -> int:
    if not nums:
        return 0
    count = nums[0]
    for i in nums[1:]:
        if i == count:
            nums.remove(i)
        else:
            count = i
    print(nums)
    return len(nums)
