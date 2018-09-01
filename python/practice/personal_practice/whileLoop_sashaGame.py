ll = ['lucas', 'sasha', 'chris', 'lucas', 'lucas']
count = 0

def checkAlivePlayers():
    new_list = []
    for player in ll:
        if player == 'lucas':
             new_list.append(player)
    print('new_list (before) is: %s' % new_list)

    new_list.pop(-1)
    print('new_list (after) is: %s' % new_list)

    return new_list

while(ll):
    for p in ll:
        print('p is: %s' % p)

    ll = checkAlivePlayers()
    count = count + 1
    print 'counter:', count

print 'dead'
