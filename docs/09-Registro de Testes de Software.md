# Registro de Testes de Software


|     Caso de teste     | CT-01 – Efetuar login                                                                                                                                                              
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados |  RF-001 - O site deve conter uma pagina de login.                                                                                                     |
|   Objetivo do Teste   |  Verificar se o usuário consegue se logar na aplicação                                                                                                                               |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3)  Clicar em "Login " <br> 4) Preencher os campos obrigatórios  <br> 5) Clicar em "Entrar" <br> |
| Dados de entrada	|  Email: teste@gmail.com,  senha: 1234
| Resultado esperado	|  Login realizado com sucesso.
|Resultado obtido	|  O usu'ario nao consegui logar sua conta.
| Avaliação (pegou / não pegou erro) | <br> Erro de Usuário e/ou senha Inválidos|
|Evidência (print screen) |   ![Captura de tela 2023-10-22 180107](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/35872e53-c4d9-404f-a2c3-5d296795a540)   |

<br><br>


|     Caso de teste     | CT-02 – Efetuar cadastro                                                                                                                                                          
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-002 - O site deve conter uma area para cadastrar novos usuários.                                                                                                    |
|   Objetivo do Teste   | Verificar se o usuário consegue se cadastrar na aplicação, com campo de preenchimento de nome, sobrenome, email e senha.                                                                                                                           |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3) Clicar em ‘Cadastrar’ <br> 4) Preencher os campos obrigatórios  <br> 5)  Clicar em ‘Cadastrar’ <br> |
| Dados de entrada	|  Nome, sobrenome, data de nascimento, email e senha |
| Resultado esperado	|  Dados armazenados no banco de dados.
|Resultado obtido	|   Os campos nome, sobrenome, data nascimento, e-mail e senha, foram armazenados com precisão no banco de dados. 
| Avaliação (pegou / não pegou erro)	| Nao possui erros
|Evidência (print screen) | Lista de usuários cadastrados frontend ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/55cd5d8c-1dce-41ec-b7c9-8cca5e03a105) <br><br> Tabela usuários cadastrados banco de dados ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/4528b550-3279-4797-b715-a9b803b7bfdf) |



<br><br>



|     Caso de teste     | CT-03 – Criar rotina                                                                                                                                                        
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-003	O sistema deve ser capaz de criar rotinas personalizadas utilizando a API do Chat GPT.                                                                                                |
|   Objetivo do Teste   |                                                                                                                       |
| Passos 	| 1- Acessar o navegador <br> 2- Informar o endereço do site.<br> 3- Fazer 'login' no site  <br>  4- Clicar em ‘Quiz da pele’  <br>  4- Responder questionário  <br> 5- Clicar em ver minha rotina |
| Resultado esperado	| Rotina personalizada é mostrada na tela para o usuário
|Resultado obtido	|  Criada rotina com sucesso. 
| Avaliação (pegou / não pegou erro)	| Não possui erros. 
|Evidência (print screen) |  ![Captura de tela 2023-10-22 171647](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/e4e4de13-c066-466e-8b20-7305e4d678ee) |


<br><br>



|     Caso de teste     | CT-04 – Excluir rotina salva                                                                                                                                                        
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-004 - O site deve permitir o usuário excluir a sua rotina salva.                                                                                                    |
|   Objetivo do Teste   | Verificar se o usuário pode excluir a rotina salva no seu painel do usuário.                                                                                                                           |
|        Passos         | - Acessar o navegador <br>  - Informar o endereço do site <br>  - Fazer 'login' no site <br>  - Acessar a ‘Area do usuário' <br> - Clicar em ‘Excluir rotina’|
| Resultado esperado	| Rotina excluida com sucesso. 
|Resultado obtido	|  Rotina excluida com sucesso.
| Avaliação (pegou / não pegou erro)	| não possui erros. 
|Evidência (print screen) |  ![Captura de tela 2023-10-22 171724](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/ea8cb593-0f2f-4709-bf79-2b084972b432) |


<br><br>


|     Caso de teste     | CT-05 – Acessar rotina salva                                                                                                                                                      
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-004	- O site deve permitir o usuário acessar a sua rotina salva. |
| Objetivo do Teste 	| Verificar se o usuário pode acessar a rotina salva no seu painel do usuário. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site.<br> - Fazer 'login' no site <br> - Acessar a ‘Area do usuário' <br>  - Clicar em ‘Visualizar rotina’ | 
| Resultado esperado	| Rotina visualizada com sucesso. 
|Resultado obtido	|  Rotina salva com sucesso 
| Avaliação (pegou / não pegou erro)	| Não possui erros 
|Evidência (print screen) |  <br> <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/c5eac8d7-4f52-48ec-81ed-76c8886b7534)  |

<br><br>



|     Caso de teste     | CT-06 – Recomendação médica	                                                                                                                                                 
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-005	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| 1- Acessar o navegador <br> 2 - Informar o endereço do site.<br> 3 - Clicar em  Quiz da pele na 'Home page'<br>  4 - Responder ao ‘Questionário’ <br>  4 -Responder "Sim" para a pergunta número 3 |
| Resultado esperado	|  É recomendado que procure ajuda médica. 
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>



|     Caso de teste     |  CT-07 – Associar a rotina com a conta do usuário                                                                                                                                              
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-006	- Associação correta e segura com a conta do usuário |
| Objetivo do Teste 	| Garantir que a rotina seja corretamente associada à conta do usuário que a gerou. |
| Passos 	| 1-	O usuário gera uma rotina na aplicação. <br> 2- A rotina é salva na conta do usuário.<br> 3- Verificar se a rotina está associada corretamente à conta do usuário em ´Minha conta´. |
| Resultado esperado	| A rotina gerada se encontra associada à conta do usuário.  
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>



|     Caso de teste     |  CT-08 – Identificação do tipo de pele                                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-007	- O sistema deve ajudar o usuário a identificar o seu tipo de pele. |
| Objetivo do Teste 	| Verificar e identificar o tipo de pele do usuário pelo questionário. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-Clicar em "Saiba como identificar seu tipo de pele" na ‘Home page’ <br> | 
| Resultado esperado	|  O usuário conseguirá indetificar o seu tipo de pele com as informações disponibilizadas.
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>


|     Caso de teste     |  CT-09 – Gerar rotinas para problemas específico                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-008, RF-009, RF-010, RF-011 - O sistema deve gerar rotinas voltadas para peles com rugas, marcas de expressoes, danos por consumo de cigarro e pele com melasma. |
| Objetivo do Teste 	| Verificar se a aplicação fornece rotinas para problemas especificos de pele. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-Clicar em "Quiz da pele" na ‘Home page’ <br> 4- Responder questionário |
| Resultado esperado	|  A rotina para cada problema específico de pele será gerada com sucesso. 
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>



|     Caso de teste     |   CT-10 – Guia sobre princípios ativos                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-012 - A aplicação deve incluir um guia completo que detalhe as funções e benefícios de cada ativo, fornecendo informações sobre como usá-los de forma eficaz. |
| Objetivo do Teste 	| Garantir que  aplicação disponiblize um guia explicativo sobre ativos de skincare. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Clicar em "O que sao os princípios ativos" na Home page |
| Resultado esperado	| Guia de princípios ativos visualizados com sucesso.
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>




|     Caso de teste     |   CT-11 –  Questionário                                                                                                      
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-013 - O sistema deve conter um questionário com perguntas detalhadas para entender a necessidade dos usuários. |
| Objetivo do Teste 	| Verificar se o usuário consegue responder o questinário . |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Fazer ‘login’ no site. <br> 4-	clicar em "Quiz da pele" na Home page <br> 5- Responder ao Questionário.|
| Resultado esperado	| Questionário foi respondido com sucesso.
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>


