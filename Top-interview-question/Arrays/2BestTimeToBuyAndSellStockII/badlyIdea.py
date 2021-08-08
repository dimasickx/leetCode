from typing import List


class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        profit = 0
        bought = float('inf')
        sell = 0
        trade = False
        for i in range(len(prices)):
            if trade:
                if prices[i] < sell:
                    profit += sell - bought
                    bought = prices[i]
                    sell = 0
                    trade = False
                elif prices[i] >= sell:
                    sell = prices[i]
                    if i + 1 == len(prices):
                        profit += sell - bought
            else:
                if prices[i] < bought:
                    bought = prices[i]
                elif prices[i] > bought:
                    sell = prices[i]
                    trade = True
                    if i + 1 == len(prices):
                        profit += sell - bought
        return profit
