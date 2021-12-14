from typing import List


class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        max_sub_array = current_sub_array = nums[0]
        for i in range(1, len(nums)):
            if nums[i] > current_sub_array + nums[i]:
                current_sub_array = nums[i]
            else:
                current_sub_array += nums[i]
            if max_sub_array < current_sub_array:
                max_sub_array = current_sub_array
        return max_sub_array

        pass


if __name__ == '__main__':
    s = Solution()
    print(s.maxSubArray([1, 2]))
