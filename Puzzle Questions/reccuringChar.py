#Return first recurring char
#so if u have GHG then G
#if u have ghi then null or none?
#and if u have GHAH then H 


def recurringCharLoop(string):
    for index in range(len(string)):
        for char in range(index):
            if string[char]  == string[index]:
                 return string[char]
    return None






# might be wrong but store the string in dic/hash map should help and make it better I think
# so if we have A B C then dic will go as following A:1 B:1 C:1 because of key must be unique and value can be anything if it see A B C A  then in the 4 interation
# it would return the character via if condition   


def recurringCharHasHMap(string):
    countTheChars  = {}
    for character in string:
        if character in countTheChars:
            return character
        countTheChars[character] = 1 
    return None


print(recurringCharLoop("ABBA"))

print(recurringCharHasHMap("ABBA"))