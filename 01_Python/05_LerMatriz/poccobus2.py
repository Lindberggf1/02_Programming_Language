# Software de venda de passagens da empresa PoccoBus
colunas = 8
linhas = 5
reservado = []
carro_matriz = []
valor = 0



# Menu de opções
def opcoes():
    print('\033[1;30;42m-----PoccoBus-----\033[m')
    print('')
    print ('[1] Poltronas' )
    print ('[2] Comprar')
    print ('[3] Ticket')
    print ('[0] Sair')
    print('')
    print('------------------\n')

# impressão da matriz
def grafico_poltronas(carro_matriz):
    linhas = len(carro_matriz)
    colunas = len(carro_matriz[0])

    for i in range(linhas):
        for j in range(colunas):
            if carro_matriz[i][j] == 'M': # Motorista
                print('\033[30;46m %s \033[m' % carro_matriz[i][j], end="")
            elif carro_matriz[i][j] == 'R': # Reservado
                print('\033[30;41m %s \033[m' % carro_matriz[i][j], end="")
            elif carro_matriz[i][j] == 'C': # Corredor 
                print('\033[30;47m %s \033[m' % carro_matriz[i][j], end="")
            else: # Poltronas 
                print('\033[30;42m %s \033[m' % carro_matriz[i][j], end="")
        print()

# número de assentos
def quantidade_assentos(linhas, colunas, carro_matriz, valor):
    lista = []
    for i in range(linhas):
        for j in range(colunas):
            if i == 0 and j == 0:
                lista.append('M') # Motorista
            elif i == 0 and j != 0:  #corredor
                lista.append('C')
            elif j == 2:  # coluna do corredor
                lista.append('C')
            else:
                valor += 1
                lista.append(valor)
        carro_matriz.append(lista[:])
        lista.clear()
    return carro_matriz

# Loop reserva de assentos, precisa do comenando '0' para interromper o loop. 
def reservar_assentos(carro_matriz, reservado):
    while True: 
        grafico_poltronas(carro_matriz)
        poltrona = int(input('Informe a poltrona desejada ou 0 para SAIR: ').replace(' ', ''))
        for disponiveis in range(len(carro_matriz)):
            for unidade in carro_matriz[disponiveis]:
                if poltrona == unidade and poltrona != 'R':
                    reservado.append(poltrona)
                    colunas = carro_matriz[disponiveis].index(unidade)
                    linhas = disponiveis
                    carro_matriz[linhas][colunas] = 'R'
        if poltrona == 0:
            break

# relátório impresso em txt
def imprimir_ticket(carro_matriz, reservado):
    with open('TicketPoccoBus.txt', 'w') as ticket:
        ticket.write('==- PoccoBus -== \n')
        ticket.write('Levando você sempre adiante \n')
        ticket.write('\n')
        ticket.write('Poltronas Reservadas \n')
        for i in reservado:
            ticket.write(f'Assento {i} reservado \n')
        ticket.write('\n')
        ticket.write('Poltronas Disponíveis \n')
        for disponiveis in range(len(carro_matriz)):
            for unidade in carro_matriz[disponiveis]:
                if unidade != 'R' and unidade != 'C' and unidade != 'M':
                    ticket.write(f'Assento {unidade} disponível \n')

        ticket.write('\n')
        ticket.close()

    print('-' * 20)
    print('\n')
    print('Ticket Gerado.')




quantidade_assentos(colunas, linhas, carro_matriz, valor)  # criação inicail da Matriz
print('\n==- PoccoBus -== \n')
print('Levando você sempre adiante\n')
while True:
    opcoes()
    try:
        opcao_main = int(input('Escolha a função: ').replace(' ', ''))

        if opcao_main == 0:
            break
        elif opcao_main == 3:
            print(' ')
            imprimir_ticket(carro_matriz, reservado)
            print(' ')
        elif opcao_main == 2:
            print(' ')
            reservar_assentos(carro_matriz, reservado)
            print(' ')
        elif opcao_main == 1:
            print(' ')
            grafico_poltronas(carro_matriz)
            print(' ')
        elif opcao_main > 3 or opcao_main  < 0:
            print('\nComando inexistente \n')     
    except ValueError:
        print('Opção Inválida')

