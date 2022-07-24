class Produto:
    def __init__(self, nome, preco):
        self.nome = nome
        self.preco = preco

    def desconto(self, percentual):
        self.preco = self.preco - (self.preco * (percentual / 100))

    # Getter
    @property
    def nome(self):
        return self._nome

    @property
    def preco(self):
        return self._preco

    # Setter
    @nome.setter
    def nome(self, valor):
        # primeira maiuscula. Minuscula é lower()
        self._nome = valor.title()

    @preco.setter
    def preco(self, valor):
        if isinstance(valor, str):
            valor = float(valor.replace('R$', ''))

        self._preco = valor


p1 = Produto('CAMISETA', 50)
p1.desconto(10)
print(p1.nome, p1.preco)

p2 = Produto('CaNeCa', 'R$15')
p2.desconto(10)
print(p2.nome, p2.preco)
