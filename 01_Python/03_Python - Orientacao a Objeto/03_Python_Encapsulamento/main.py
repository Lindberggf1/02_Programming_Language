'''
Public, protect, private
_ privado/protec, (pubic _), mas ainda consigo mudar fora da classe.
__ private, (_NOMECLASSE__nomeatributo), aqui fortemente recomendo nao mudar fora da classe. Evita ele ser sobrescrito.
'''


class BaseDeDados:
    def __init__(self):
        # criar um dicionario
        self.__dados = {}

    @property
    def dados(self):
        return self.__dados

    def inserir_cliente(self, id, nome):
        if 'clientes' not in self.__dados:
            self.__dados['clientes'] = {id: nome}
        else:
            self.__dados['clientes'].update({id: nome})

    def lista_clientes(self):
        for id, nome in self.__dados['clientes'].items():
            print(id, nome)

    def apaga_clientes(self, id):
        del self.__dados['clientes'][id]


bd = BaseDeDados()
bd.inserir_cliente(1, 'Otávio')
bd.inserir_cliente(2, 'Miranda')
bd.inserir_cliente(3, 'Rose')
# bd.apaga_clientes(2)
#bd.lista_clientes()

# ao fazr isso com dois anderlines ele cria outro, sem mexer com o privado.
bd.__dados = 'Outra coisa'

#parar printar o atributo original
print(bd._BaseDeDados__dados)


