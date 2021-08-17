# Definition for a binary tree node.
import math
from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        return self.recursion_validate(-math.inf, math.inf, root)

    def recursion_validate(self, lower, upper, root):
        if not root:
            return True
        if lower >= root.val or root.val >= upper:
            return False
        return self.recursion_validate(root.val, upper, root.right) and \
               self.recursion_validate(lower, root.val, root.left)


if __name__ == '__main__':
    s = Solution()
    a = TreeNode(3)
    b = TreeNode(2)
    c = TreeNode(5)
    d = TreeNode(4)
    e = TreeNode(7)
    f = TreeNode(4)
    g = TreeNode(8)
    a.left = b
    a.right = c
    c.left = d
    c.right = e
    e.left = f
    e.right = g
    print(s.isValidBST(a))
