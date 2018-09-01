ll = ['lucas', 'sasha', 'chris', 'lucas']
count = 0

def checkAlivePlayers():
    new_list = []
    for player in ll:
        if player == 'lucas':
             new_list.append(player)
    print('new_list is: %s' % new_list)

    return new_list

while(ll):
    for p in ll:
        print('p is: %s' % p)

    ll = checkAlivePlayers()
    count = count + 1
    print count

print 'dead'
