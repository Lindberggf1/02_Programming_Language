import urllib
import urllib.request

try:
    sit = urllib.request.urlopen('http://www.pudim.com.br')
except (urllib.error.URLError):
    print('Deu erro url Error, não acessecivel no momento.')
except:
    print('Erro desconhecido.')
else:
    print('Acessou com sucesso o site Pudim.')
    print(sit.read())
