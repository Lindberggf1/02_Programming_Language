col = 5
lin = 8
matriz = []
valor = 0
a_reservado = []


def main_menu():
    print('[ 1 ] Ver assentos')
    print('[ 2 ] Comprar passagens')
    print('[ 3 ] Relatório')
    print('[ 0 ] Sair')


def num_assentos(col, lin, matriz, valor):
    lista = []
    for i in range(lin):
        for j in range(col):
            if i == 0 and j == 0:
                lista.append('M')
            elif i == 0 and j != 0:  # corredor
                lista.append('C')
            elif j == 2:  # coluna do corredor
                lista.append('C')
            else:
                valor += 1
                lista.append(valor)
        matriz.append(lista[:])
        lista.clear()
    return matriz


def impressao_assentos(matriz):
    linhas = len(matriz)
    colunas = len(matriz[0])

    for i in range(linhas):
        for j in range(colunas):
            if matriz[i][j] == 'M':
                print('\033[33m %s \033[m' % matriz[i][j], end="")
            elif matriz[i][j] == 'C':
                print('\033[37m %s \033[m' % matriz[i][j], end="")
            elif matriz[i][j] == 'XX':
                print('\033[31m %s \033[m' % matriz[i][j], end="")
            else:
                print('\033[32m %s \033[m' % matriz[i][j], end="")
        print()


def reserva_assento(matriz, a_reservado):
    while True:  # enquanto não definir sair, o loop funciona
        impressao_assentos(matriz)
        assento = int(input('Por favor, informe o número do assento ou 0 para SAIR: ').replace(' ', ''))
        for disponiveis in range(len(matriz)):
            for elemento in matriz[disponiveis]:
                if assento == elemento and assento != 'XX':
                    a_reservado.append(assento)
                    col = matriz[disponiveis].index(elemento)
                    lin = disponiveis
                    matriz[lin][col] = 'XX'
        if assento == 0:
            break


def imprimir_relatorio(matriz, a_reservado):
    with open('relatorioPoccoBus.txt', 'w') as relatorio:
        relatorio.write('PoccoBus \n')
        relatorio.write('Viagens e fretados \n')
        relatorio.write('\n')
        relatorio.write('Essa é a relação de Assentos Ocupados \n')
        for i in a_reservado:
            relatorio.write(f'Assento {i} está reservado \n')
        relatorio.write('\n')
        relatorio.write('Essa é a relação de Assentos Disponíveis \n')
        for disponiveis in range(len(matriz)):
            for elemento in matriz[disponiveis]:
                if elemento != 'XX' and elemento != 'C' and elemento != 'M':
                    relatorio.write(f'Assento {elemento} está disponível \n')

        relatorio.write('\n')
        relatorio.close()

    print('*' * 45)
    print('\n')
    print('Relatório gerado com sucesso.')


num_assentos(col, lin, matriz, valor)  # criação inicail da Matriz
print('PoccoBus')
print('Viagens e Fretados')
while True:
    main_menu()
    try:
        opcao_main = int(input('Digite a opção desejada: ').replace(' ', ''))

        if opcao_main == 0:
            break
        elif opcao_main == 3:
            print(' ')
            imprimir_relatorio(matriz, a_reservado)
            print(' ')
        elif opcao_main == 2:
            print(' ')
            reserva_assento(matriz, a_reservado)
            print(' ')
        elif opcao_main == 1:
            print(' ')
            impressao_assentos(matriz)
            print(' ')
    except ValueError:
        print('Opção Inválida')
