def main():
    a = [0, 3, 2, 3, 4]
    b = a # b e apelido para a
    b[1] = 5

    c=a[:]
    c[1]=3

    print("a = ", a)
    print("b = ", b)
    print("c = ", c)



main()

