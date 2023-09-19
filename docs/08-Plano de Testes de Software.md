# Plano de Testes de Software

Plano de teste de software (caso de testes)
Os requisitos para os testes de softwares são: 
- Site publicado na Internet
- Navegador da internet – Chrome, Firefox ou Edge.
- Conectividade com a internet para acesso as plataformas API’S 

Os testes serão baseados na metodologia a seguir

- Teste de unidade – o principal objetivo do teste de unidade é verificar se pequenas partes do código, as unidades, funcionam como o esperado.
- Teste de integração – o principal objetivo do teste de integração é garantir que os diferentes componenentes, módulos ou unidades do software possam ser combinados e operar juntos de maneira eficiente e sem problemas.

 
| **Caso de Teste** 	| **CT-01 – Efetuar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O site deve conter uma pagina de login. |
| Objetivo do Teste 	| Verificar se o usuário consegue se logar na aplicação |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login " <br> - Preencher os campos obrigatórios. <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar cadastro	|
|Requisito Associado | RF-002	- O site deve conter uma area para cadastrar novos usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação, com campo de preenchimento de nome, sobrenome, email e senha. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Clicar em ‘Cadastrar’ <br> - Preencher os campos obrigatórios (Nome, sobrenome, data de nascimento, email e senha) <br>  - Clicar em ‘Cadastrar’ |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-03 – Acessar rotina salva	|
|Requisito Associado | RF-004	- O site deve permitir o usuário a acessar a sua rotina salva. |
| Objetivo do Teste 	| Verificar se o usuário pode acessar a rotina salva no seu painel do usuário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - Clicar em ‘Acessar rotina’ |
|Critério de Êxito | - Rotina visualizada com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Excluir e criar rotina	|
|Requisito Associado | RF-004	- O site deve permitir o usuário a excluir e a criar uma nova rotina. |
| Objetivo do Teste 	| Verificar se o usuário pode alterar as rotinas salvas no seu painel. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - 	Clicar em ‘Excluir rotina’ <br>	Clicar em ‘Criar uma nova rotina’ |
|Critério de Êxito | - Rotina criada com sucesso |
|  	|  	|
| Caso de Teste 	| CT-05 – Excluir e criar rotina	|
|Requisito Associado | RF-005	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - Responder ao ‘Questionário’ |
|Critério de Êxito | - É recomendado que procure ajuda médica. |
|  	|  	|
| Caso de Teste 	| CT-06 – Excluir e criar rotina	|
|Requisito Associado | RF-006	- Associação correta com a conta do usuário |
| Objetivo do Teste 	| Garantir que a rotina seja corretamente associada à conta do usuário que a gerou. |
| Passos 	| -	O usuário gera uma rotina na aplicação. <br> - A rotina é salva na conta do usuário.<br> - Verificar se a rotina está associada corretamente à conta do usuário. |
|Critério de Êxito | - A rotina está associada à conta do usuário que a gerou. |

 
