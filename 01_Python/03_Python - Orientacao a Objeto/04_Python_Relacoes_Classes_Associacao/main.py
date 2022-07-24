'''
Associado, onde elas se relacionam, mas não depende. Podem viver sem uma outra.
'''

from classes import Escritor
from classes import Caneta
from classes import MaquinaDeEscrever

escritor = Escritor('Joãozinho')
caneta = Caneta('Bic')
maquina = MaquinaDeEscrever()

print(escritor.nome)
print(caneta.marca)
print(maquina)

#associacao
escritor.ferramenta = caneta
escritor.ferramenta.escrever()

escritor.ferramenta = maquina
escritor.ferramenta.escrever()

# demosntrar mesmo apagando escritor as demais ainda exitem, por se uma associacao, elas se ligam mas não dependem para viver.
del escritor
print(caneta.marca)
maquina.escrever()





