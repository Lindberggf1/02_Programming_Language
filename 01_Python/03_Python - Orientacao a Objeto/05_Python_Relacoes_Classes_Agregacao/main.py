'''
Agregação: usa outra classe como parte de si, e precisa desta outra classe para existir.
'''

from classes import CarrinhoDeCompras, Produto

carrinho = CarrinhoDeCompras()

p1 = Produto('Camiseta', 50)
p2 = Produto('IPhone', 10000)
p3 = Produto('Caneca', 15)

carrinho.inseri_produto(p1)
carrinho.inseri_produto(p2)
carrinho.inseri_produto(p3)
carrinho.inseri_produto(p2)
carrinho.inseri_produto(p1)
carrinho.inseri_produto(p2)
carrinho.inseri_produto(p3)

carrinho.lista_produto()
print(carrinho.soma_total())




