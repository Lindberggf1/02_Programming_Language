
def voto(n):
    from datetime import datetime
    id = datetime.now().year - n
    if id < 16:
        print(f'O voto para {id} anos é NEGADO.')
    elif 16 >= id < 18 or id > 65:
        print(f'O voto para {id} anos é OPCIONAL.')
    else:
        print(f'O voto para {id} anos é OBRIGATÓRIO.')


voto(2005)
