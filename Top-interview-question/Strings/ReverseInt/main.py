class Solution:
    def reverse(self, x: int) -> int:
        if x >= 0:
            r = int(str(x)[::-1])
        else:
            r = -1 * int(str(x * -1)[::-1])
        minimum = -2 ** 31
        maximum = 2 ** 31 - 1
        if minimum < r < maximum:
            return r
        else:
            return 0


if __name__ == '__main__':
    s = Solution()
    print(s.reverse(-123))
