def ficha(j = '<desconhecido>', gols = 0):
    print(f'O jogador {j} fez {gols} no(s) campeonato.')

#promgrama principal
n= str(input('Nome do jogador: '))
g = str(input('Numero de gosl: '))
if g.isnumeric():
    g = int(g)
else:
    g = 0
if n.strip() == '':
    ficha(gols=g)
else:
    ficha(n, g)

