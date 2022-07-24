'''
Associacao - Usa outro objeto.
Agregacao - Tem outro objeto.
Composicao - É dono outro objeto.
Herança = É outro objeto.
'''

from classes import Pessoa
from classes import Cliente
from classes import Aluno

c1 = Cliente('Luiz', 45)
print(c1.nome)
c1.falar()
c1.comprar()
print()

a1 = Aluno('Maria', 13)
print(a1.nome)
a1.falar()
a1.estudar()
print()

p1 = Pessoa('João', 45)
print(p1.nome)
p1.falar()
print()

