# appleStocks
stock_prices_yesterday = [100, 70, 5, 3]


def get_max_profit(stock_prices_yesterday):
    L = stock_prices_yesterday
    best_profit = -1000000

    for i in range(0, len(L)): # looping through the list once
        for j in range(i + 1, len(L)):  # looping through the list again, checking every other item

            if L[i] < L[j]:    # if a price is less than what it is LATER
                profit = L[j] - L[i]       # find the price difference(profit)
                #print "Buy at: %s, Sell at: %s, profit= %s" % (i, j, profit)

                best_profit = max(best_profit, profit)
                # buy_index = i
                # sell_index = j
                #print "Best profit:", best_profit

            elif L[i] >= L[j]:  # if we can't profit, try not lose as little as possible
                bad_profit = L[j] - L[i]

                best_profit = max(best_profit, bad_profit)

            buy_index = i
            sell_index = j

    print "Buy at index %s" % buy_index
    print "Sell at index %s" % sell_index
    print "Best profit: $%s" % best_profit


if __name__ == '__main__':
    get_max_profit(stock_prices_yesterday)
