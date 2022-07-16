def leiaInt(msg):
    while True:
        try:
            n = int(input(msg))
        except (ValueError, TypeError):
            print('\033[31mErro!! Por favor, digite um número inteiro valido.\033[m')
            continue
        except (KeyboardInterrupt):
            print('\n\033[31mErro!! Entrada de dados interrompida pelo usuario, ou não quis digitar o número.\033[m')
            return 0
        else:
            return n


def leiaFloat(msg):
    while True:
        try:
            n = float(input(msg))
        except (ValueError, TypeError):
            print('\033[31mERRo! Por favor, digite um número float válido. \033[m')
            continue
        except (KeyboardInterrupt):
            print('\n\033[31mERRO! Entrada de dados interrompida pelo usuario, ou não quis digitar o número. \033[m')
            return 0
        else:
            return n


#==== Programa Principal ======
n1 = leiaInt('Digite um numero inteiro: ')
n2 = leiaFloat('Digite um numero float: ')
print(f'O valor digitado foi: interio {n1} e o float {n2}.')
