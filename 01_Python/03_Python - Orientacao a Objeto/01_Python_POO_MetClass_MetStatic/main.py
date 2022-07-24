from pessoa import Pessoa

# p1.por_ano_nascimento('Luiz', 32)

p1 = Pessoa('Luiz', 29)
p2 = Pessoa('João', 32)

p1.falar('POO')
p2.falar('Filme')

print(p1.idade)

print(p1.get_ano_nascimento())
print(p2.get_ano_nascimento())

print(f"{Pessoa.gera_id():%<20} {p2.get_ano_nascimento():_>20}")
print(p1.gera_id())
