# Definition for a binary tree node.
from typing import Optional


class TreeNode:
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right


class Solution:
    def maxDepth(self, root: Optional[TreeNode]) -> int:
        if not root:
            return 0
        return max(1 + self.maxDepth(root.left), 1 + self.maxDepth(root.right)) - 1


if __name__ == '__main__':
    s = Solution()
    a = TreeNode(3)
    b = TreeNode(9)
    # c = TreeNode(20)
    # d = TreeNode(15)
    # e = TreeNode(7)
    a.right = b
    # a.right = c
    # c.left = d
    # c.right = e
    print(s.maxDepth(a))
