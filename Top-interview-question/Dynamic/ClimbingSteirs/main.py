class Solution:
    def climbStairs(self, n: int) -> int:
        if n == 1:
            return 1
        cache1, cache2 = 1, 2
        for _ in range(2, n):
            cache1, cache2 = cache2, cache1 + cache2
        return cache2


if __name__ == '__main__':
    s = Solution()
    print(s.climbStairs(5))
