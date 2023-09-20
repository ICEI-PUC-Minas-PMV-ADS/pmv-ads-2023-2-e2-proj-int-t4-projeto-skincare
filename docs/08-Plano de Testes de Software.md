# Plano de Testes de Software

Plano de teste de software (caso de testes)
Os requisitos para os testes de softwares são: 
- Site publicado na Internet
- Navegador da internet – Chrome, Firefox ou Edge.
- Conectividade com a internet para acesso as plataformas API’S 

Os testes serão baseados na metodologia a seguir

- Teste de unidade – o principal objetivo do teste de unidade é verificar se pequenas partes do código, as unidades, funcionam como o esperado.
- Teste de integração – o principal objetivo do teste de integração é garantir que os diferentes componenentes, módulos ou unidades do software possam ser combinados e operar juntos de maneira eficiente e sem problemas.

## Segue abaixo cada caso de teste de software

| **Caso de Teste** 	| **CT-01 – Efetuar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - O site deve conter uma pagina de login. |
| Objetivo do Teste 	| Verificar se o usuário consegue se logar na aplicação |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login " <br> - Preencher os campos obrigatórios. <br> - Clicar em "Entrar" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-02 – Efetuar cadastro	|
|Requisito Associado | RF-002	- O site deve conter uma area para cadastrar novos usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação, com campo de preenchimento de nome, sobrenome, email e senha. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Clicar em ‘Cadastrar’ <br> - Preencher os campos obrigatórios (Nome, sobrenome, data de nascimento, email e senha) <br>  - Clicar em ‘Cadastrar’ |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-04 – Criar rotina	|
|Requisito Associado | RF-004	- O site deve permitir o usuário  a criar uma  rotina. |
| Objetivo do Teste 	| Verificar se o usuário pode criar uma rotina. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Clicar em Quiz da pele na  ‘home page' <br>  - 	Responder ás perguntas do questionário <br> ' Clicar en Enviar|
|Critério de Êxito | - Rotina criada com sucesso |
|  	|  	|
| **Caso de Teste** 	| CT-03 – Excluir rotina salva	|
|Requisito Associado | RF-004	- O site deve permitir o usuário excluir a sua rotina salva. |
| Objetivo do Teste 	| Verificar se o usuário pode excluir a rotina salva no seu painel do usuário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - Clicar em ‘Excluir rotina’ |
|Critério de Êxito | - Rotina excluida com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-04 – Acessar rotina salva	|
|Requisito Associado | RF-004	- O site deve permitir o usuário acessar a sua rotina salva. |
| Objetivo do Teste 	| Verificar se o usuário pode acessar a rotina salva no seu painel do usuário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - Clicar em ‘Visualizar rotina’ |
|Critério de Êxito | - Rotina visualizada com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-06 – Recomendação médica	|
|Requisito Associado | RF-005	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Clicar em  Quiz da pele na 'Home page'<br>  - Responder ao ‘Questionário’ |
|Critério de Êxito | - É recomendado que procure ajuda médica. |
|  	|  	|
| **Caso de Teste** 	| CT-07 – Associar a conta do usuário	|
|Requisito Associado | RF-006	- Associação correta com a conta do usuário |
| Objetivo do Teste 	| Garantir que a rotina seja corretamente associada à conta do usuário que a gerou. |
| Passos 	| -	O usuário gera uma rotina na aplicação. <br> - A rotina é salva na conta do usuário.<br> - Verificar se a rotina está associada corretamente à conta do usuário. |
|Critério de Êxito | - A rotina está associada à conta do usuário que a gerou. |
|  	|  	|
| **Caso de Teste** 	| CT-08 – Armazenamento	|
|Requisito Associado | RF-006	- Associação correta com a conta do usuário |
| Objetivo do Teste 	| Verificar se os dados da rotina são armazenados de forma segura e protegida. |
| Passos 	| -	O usuário gera uma rotina na aplicação <br> - A rotina é salva na conta do usuário.<br> -	Tentativa de acesso não autorizado aos dados da rotina. |
|Critério de Êxito | - O acesso não autorizado é bloqueado, garantindo a segurança do armazenamento da rotina. |
|  	|  	|
| **Caso de Teste** 	| CT-09 – Identificação do tipo de pele	|
|Requisito Associado | RF-007	- O sistema deve ajudar o usuário a identificar o seu tipo de pele. |
| Objetivo do Teste 	| Verificar e identificar o tipo de pele do usuário pelo questionário. |
| Passos 	| -	Acessar o navegador <br> - Informar o endereço do site. <br> -Clicar em "Saiba como identificar seu tipo de pele" na ‘Home page’ <br> |
|Critério de Êxito | O usuário conseguirá indetificar o seu tipo de pele com as informações disponibilizadas. |
|  	|  	|
| **Caso de Teste** 	| CT-10 – Gerar rotinas para problemas específicos|
|Requisito Associado | RF-008, RF-009, RF-010, RF-011 - O sistema deve gerar rotinas voltadas para peles com rugas, marcas de expressoes, danos por consumo de cigarro e pele com melasma. |
| Objetivo do Teste 	| Verificar que a aplicação forneça rotinas para problemas especificos de pele. |
| Passos 	| -	Acessar o navegador <br> - Informar o endereço do site. <br> -	Fazer ‘login’ no site <br> - Clicar em Quiz da pele  na ‘Home page’ <br> - Responder ao ‘Questionário’. <br> 'Clicar em Enviar |
|Critério de Êxito | - A rotina para cada problema específico de pele será gerada com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-11 – Guia sobre princípios ativos	|
|Requisito Associado | RF-012 - A aplicação deve incluir um guia completo que detalhe as funções e benefícios de cada ativo, fornecendo informações sobre como usá-los de forma eficaz. |
| Objetivo do Teste 	| Garantir que  aplicação disponiblize um guia sobre ativos de skincare. |
| Passos 	| -	Acessar o navegador <br> - Informar o endereço do site. <br> -	Clicar em "O que sao os princípios ativos" na Home page |
|Critério de Êxito | - Guia de princípios ativos visualizados com sucesso. |
|  	|  	|
| **Caso de Teste** 	| CT-12 – Questionário	|
|Requisito Associado | RF-013 - O sistema deve conter um questionário com perguntas detalhadas para entender a necessidade dos usuários, e gerar a rotoina de skincare. |
| Objetivo do Teste 	| Verificar se o usuário consegue responder o questinário . |
| Passos 	| -	Acessar o navegador <br> - Informar o endereço do site. <br> -	Fazer ‘login’ no site. <br> -	clicar em "Quiz da pele" na Home page <br> - Responder o Questionário.|
|Critério de Êxito | - Questionário foi respondido com sucesso. |





