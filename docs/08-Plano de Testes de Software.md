# Plano de Testes de Software

Plano de teste de software (caso de testes)
Os requisitos para os testes de softwares são: 
- Site publicado na Internet
- Navegador da internet – Chrome, Firefox ou Edge.
- Conectividade com a internet para acesso as plataformas API’S 

Os testes serão baseados na metodologia a seguir:

- Teste de funcionalidades – o principal objetivo do teste  é verificar  e tudo funciona  como o esperado.
- Teste de integração – o principal objetivo do teste de integração é garantir que os diferentes componenentes, módulos ou unidades do software possam ser combinados e operar juntos de maneira eficiente e sem problemas.

## Segue abaixo cada caso de teste de software

|     Caso de teste     | CT-01 – Efetuar login                                                                                                                                                              
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados |  RF-001 - O site deve conter uma pagina de login.                                                                                                     |
|   Objetivo do Teste   |  Verificar se o usuário consegue se logar na aplicação                                                                                                                               |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3)  Clicar em "Login " <br> 4) Preencher os campos obrigatórios  <br> 5) Clicar em "Entrar" <br> |
| Dados de entrada	|  Email e senha
| Resultado esperado	|  Login realizado com sucesso.
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro) | |


<br><br>

|     Caso de teste     | CT-02 – Efetuar cadastro                                                                                                                                                          
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-002 - O site deve conter uma area para cadastrar novos usuários que tenham a partir de 16 anos.                                                                                                    |
|   Objetivo do Teste   | Verificar se o usuário consegue se cadastrar na aplicação, com campo de preenchimento de nome, sobrenome, email e senha.                                                                                                                           |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3) Clicar em ‘Cadastrar’ <br> 4) Preencher os campos obrigatórios  <br> 5)  Clicar em ‘Cadastrar’ <br> |
| Dados de entrada	|  Nome, sobrenome, data de nascimento, email e senha |
| Resultado esperado	| Os dados do usuário forma salvos na base de dados, e ele conseguirá se logar na aplicacao.
|Resultado obtido	|    
| Avaliação (pegou / não pegou erro)	| 

<br><br>


|     Caso de teste     | CT- 03  – Criar rotina ao responder um questionário                                                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-003, RF-011: 	O sistema deve ser capaz de criar rotinas personalizadas de skincare ao responder um questionário, utilizando a api do OpenAI. <br>  RF-013 O sistema deve conter um questionário com perguntas detalhadas para entender as necessidades dos usuários.                            
|   Objetivo do Teste   |  Verificar se o usuário consegue gerar sua rotina personalizado ao responder o questionário.                                                                                                                     |
| Passos 	| 1- Acessar o navegador <br> 2- Informar o endereço do site.<br> 3- Fazer 'login' no site  <br>  4- Clicar em ‘Quiz da pele’  <br>  4- Responder questionário  <br> 5- Clicar em ver minha rotina |
| Resultado esperado	| Rotina personalizada é mostrada na tela para o usuário|
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	|	


<br><br>


|     Caso de teste     | CT-04 – Recomendação médica	                                                                                                                                                 
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-004	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| 1- Acessar o navegador <br> 2 - Informar o endereço do site.<br> 3 - Clicar em  Quiz da pele na 'Home page'<br>  4 - Responder ao ‘Questionário’ <br>  4 -Responder "Sim" para a pergunta número 3 |
| Resultado esperado	|  É recomendado que procure ajuda médica. 
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| |

<br><br>


|     Caso de teste     |  CT-05 – Identificação do tipo de pele                                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-005	- O sistema deve ajudar o usuário a identificar o seu tipo de pele. |
| Objetivo do Teste 	| Verificar e identificar o tipo de pele do usuário pelo questionário. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-Clicar em "Saiba como identificar seu tipo de pele" na ‘Home page’ <br> | 
| Resultado esperado	|  O usuário conseguirá indetificar o seu tipo de pele com as informações disponibilizadas.
|Resultado obtido	|
| Avaliação (pegou / não pegou erro)	| |



<br><br>

|     Caso de teste     |  CT-06 – Gerar rotinas para problemas específico                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-006, RF-007, RF-008, RF-009 - O sistema deve gerar rotinas voltadas para peles com rugas, marcas de expressoes, danos por consumo de cigarro e pele com melasma. |
| Objetivo do Teste 	| Verificar se a aplicação fornece rotinas para problemas especificos de pele. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3- Fazer o login no sistema <br> 4- Clicar em "Quiz da pele" na ‘Home page’ <br> 5- Responder questionário |
| Resultado esperado	|  A rotina para cada problema específico de pele será gerada com sucesso. 
|Resultado obtido	| 
| Avaliação (pegou / não pegou erro)	| |


<br><br>


|     Caso de teste     |   CT-07 – Guia sobre princípios ativos                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-010 - A aplicação deve incluir um guia completo que detalhe as funções e benefícios de cada ativo, fornecendo informações sobre como usá-los de forma eficaz. |
| Objetivo do Teste 	| Garantir que  aplicação disponiblize um guia explicativo sobre ativos de skincare. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Clicar em "O que sao os princípios ativos" na Home page |
| Resultado esperado	| Guia de princípios ativos visualizados com sucesso.
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| |

<br><br>
# Registro de Testes Regras de negócio


|     Caso de teste     |   CT-01 – Cadastro a partir de 16 anos                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|01 |O cadastro de novos usuários será finalizado somente após o preenchimento de todos os campos obrigatórios, e a confirmação de que o usuário possui no mínimo 16 anos de idade.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar com idade inferior a 16 anos. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Acessar login e clicar em cadastro. <br> 4-	Preencher todos os campos, e na data de nascimento selecionar o ano atual, ou outro de sua escolha, onde a idade  seja inferior a 16 anos. <br> 5- Clicar no botao cadastrar.
| Resultado esperado	|O cadastro nao é efetuado, e um alerta aparece na tela, informando que o usuário deve ter 16 anos ou mais.
|Resultado obtido	| 
| Avaliação (pegou / não pegou erro)	| |
<br><br>
