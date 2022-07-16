km = float(input('Quantos KM rodados: '))
D = float(input('Quantos dias alugado: '))

tk = km * 0.15
td = D * 60

t = tk + td

print('Total a pagar é R${}.'.format(t))

