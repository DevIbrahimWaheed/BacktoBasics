#Return first recurring char
#so if u have GHG then G
#if u have ghi then null or none?
#and if u have GHAH then H 


def recurringCharD(string):
    for index in range(len(string)):
        for char in range(index):
            if string[char]  == string[index]:
                 return string[char]
    return None




print(recurringCharD("ABCSBA"))