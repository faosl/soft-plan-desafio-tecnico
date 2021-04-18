# DESAFIO TÉCNICO SOFTPLAN ASP.NET CORE 5

# REQUISITOS
Docker instalado.

Antes de executar os comandos abaixos verifique se portas 9090 e 9191 estão liberadas no host.

# RODAR APLICAÇÃO
git clone https://github.com/faosl/soft-plan-desafio-tecnico

cd soft-plan-desafio-tecnico

docker-compose up

# ACESSO AOS SWAGGERS
Api1: http://localhost:9090/swagger
Api2: http://localhost:9191/swagger

# CENÁRIO

Criar duas API's uma com dois endpoints e outra com um endpoint:

# API 1

Retorna taxa de juros
Responde pelo path relativo "/taxaJuros" Retorna o juros de 1% ou 0,01 (fixo no código)
Exemplo: /taxaJuros Resultado esperado: 0,01

# API 2

Calcula Juros Responde pelo path relativo "/calculajuros" Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final = Valor Inicial * (1 + juros) ^ Tempo Valor inicial é um decimal recebido como parâmetro. Valor do Juros deve ser consultado na API 1. Tempo é um inteiro, que representa meses, também recebido como parâmetro. ^ representa a operação de potência. Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

Exemplo: /calculajuros?valorinicial=100&meses=5 Resultado esperado: 105,10

Show me the code
Este responde pelo path relativo /showmethecode Deverá retornar a url de onde encontra-se o fonte no github
