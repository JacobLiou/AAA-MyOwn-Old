key_list = [1, 2, 3]
value_list = ["good", "bad", "evil"]

dic = dict(zip(key_list, value_list))
print(dic)

merge_list = key_list + value_list
print(merge_list)


def merge(*args, missing_val = None):
    max_length = max([len(lst) for lst in args])
    outList = []
    for i in range(max_length):
        subList = []
        for k in range(len(args)):
            subList.append(args[k][i])
        outList.append(subList)
    return outList

print(merge([1,2,3],[ 'a' , 'b' , 'c' ], [ 'h' , 'e' , 'y' ],[4,5,6]))