# Registro de Testes de Software


|     Caso de teste     | CT-01 – Efetuar login                                                                                                                                                              
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados |  RF-001 - O site deve conter uma pagina de login.                                                                                                     |
|   Objetivo do Teste   |  Verificar se o usuário consegue se logar na aplicação                                                                                                                               |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3)  Clicar em "Login " <br> 4) Preencher os campos obrigatórios  <br> 5) Clicar em "Entrar" <br> |
| Dados de entrada	|  Email e senha
| Resultado esperado	|  Login realizado com sucesso.
|Resultado obtido	|  O usuário conseguiu acessar seus dois tipos de contas (user normal e adm).
| Avaliação (pegou / não pegou erro) | Sem erros|
|Evidência (print screen) |  Ao se logar com conta usuário normal "Minha conta" aparece na barra de navegação.  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/67f072f0-a618-4934-8a59-aa83c7fa23e8)  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/628b7c01-cf1e-424a-8965-eca913b0df36) <br><br>  Login conta administrador aparece "Administrador na barra de navegação.  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/d8514ee8-fe01-4062-bc92-2808fd58482c)  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/4f2d69af-d57e-4f1b-9776-8159f9077c87)

 

<br><br>


|     Caso de teste     | CT-02 – Efetuar cadastro                                                                                                                                                          
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-002 - O site deve conter uma area para cadastrar novos usuários que tenham a partir de 16 anos.                                                                                                    |
|   Objetivo do Teste   | Verificar se o usuário consegue se cadastrar na aplicação, com campo de preenchimento de nome, sobrenome, email e senha.                                                                                                                           |
|        Passos         | 1) Acessar o Navegador <br> 2) Informar o endereço do Site:  <br> 3) Clicar em ‘Cadastrar’ <br> 4) Preencher os campos obrigatórios  <br> 5)  Clicar em ‘Cadastrar’ <br> |
| Dados de entrada	|  Nome, sobrenome, data de nascimento, email e senha |
| Resultado esperado	|  Dados armazenados no banco de dados.
|Resultado obtido	|   Os campos nome, sobrenome, data nascimento, e-mail e senha, foram armazenados com precisão no banco de dados, criando o acesso do usuário no sistema. 
| Avaliação (pegou / não pegou erro)	| Nao possui erros
|Evidência (print screen) |![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/8ce457b7-f3ae-45bc-89a7-4932781ab35f) <br><br> Lista de usuários cadastrados frontend ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/942d4c58-366e-42d2-8010-8943a679267d) <br><br> Tabela usuários cadastrados banco de dados ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/602089d4-2295-47b1-8af6-8bb010d706a6)|



<br><br>


|     Caso de teste     | CT- 03  – Criar rotina ao responder um questionário                                                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-003, RF-011: 	O sistema deve ser capaz de criar rotinas personalizadas de skincare ao responder um questionário, utilizando a api do OpenAI. <br>  RF-013 O sistema deve conter um questionário com perguntas detalhadas para entender as necessidades dos usuários.                                                                                               |
|   Objetivo do Teste   |  Verificar se o usuário consegue gerar sua rotina personalizado ao responder o questionário.                                                                                                                     |
| Passos 	| 1- Acessar o navegador <br> 2- Informar o endereço do site.<br> 3- Fazer 'login' no site  <br>  4- Clicar em ‘Quiz da pele’  <br>  4- Responder questionário  <br> 5- Clicar em ver minha rotina |
| Resultado esperado	| Rotina personalizada é mostrada na tela para o usuário
|Resultado obtido	|  Rotina criada com sucesso. 
| Avaliação (pegou / não pegou erro)	| Não possui erros. 
|Evidência (print screen) |  Ao responder o questionário, a rotina é gerada com sucesso.  <br>  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/df266584-e049-4f38-916d-2dcc99da7c21)  <br><br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/8b4890ef-73ac-4340-bb14-ce4a58810f67)|


<br><br>



|     Caso de teste     | CT-04 – Recomendação médica	                                                                                                                                                 
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-004	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| 1- Acessar o navegador <br> 2 - Informar o endereço do site.<br> 3 - Clicar em  Quiz da pele na 'Home page'<br>  4 - Responder ao ‘Questionário’ <br>  4 -Responder "Sim" para a pergunta número 3 |
| Resultado esperado	|  É recomendado que procure ajuda médica. 
|Resultado obtido	|  Ao selecionar a resposta "Sim" para a pergunta 3, a rotina nao é gerada, e o alerta com a mensagem aparece na tela.
| Avaliação (pegou / não pegou erro)	| Sem erros
|Evidência (print screen) |A resposta Sim é selecionada na pergunta 3 <br><br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/9c23a06e-a859-495c-be6f-d6408f3cee8b) <br> <br> Alerta do erro <br><br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/956700a9-b886-421f-b0e6-25f1584c0f80)

<br><br>



|     Caso de teste     |  CT-05 – Identificação do tipo de pele                                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-005	- O sistema deve ajudar o usuário a identificar o seu tipo de pele. |
| Objetivo do Teste 	| Verificar e identificar o tipo de pele do usuário pelo questionário. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-Clicar em "Saiba como identificar seu tipo de pele" na ‘Home page’ <br> | 
| Resultado esperado	|  O usuário conseguirá indetificar o seu tipo de pele com as informações disponibilizadas.
|Resultado obtido	|  Página tipo de pele visualizada com sucesso
| Avaliação (pegou / não pegou erro)	| Sem erros
|Evidência (print screen) |  ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/35f2946c-024c-463c-af77-6b9f2a5a1c02)


<br><br>


|     Caso de teste     |  CT-06 – Gerar rotinas para problemas específico                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-006, RF-007, RF-008, RF-009 - O sistema deve gerar rotinas voltadas para peles com rugas, marcas de expressoes, danos por consumo de cigarro e pele com melasma. |
| Objetivo do Teste 	| Verificar se a aplicação fornece rotinas para problemas especificos de pele. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-Clicar em "Quiz da pele" na ‘Home page’ <br> 4- Responder questionário |
| Resultado esperado	|  A rotina para cada problema específico de pele será gerada com sucesso. 
|Resultado obtido	|  
| Avaliação (pegou / não pegou erro)	| 
|Evidência (print screen) |  

<br><br>



|     Caso de teste     |   CT-07 – Guia sobre princípios ativos                                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-010 - A aplicação deve incluir um guia completo que detalhe as funções e benefícios de cada ativo, fornecendo informações sobre como usá-los de forma eficaz. |
| Objetivo do Teste 	| Garantir que  aplicação disponiblize um guia explicativo sobre ativos de skincare. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Clicar em "O que sao os princípios ativos" na Home page |
| Resultado esperado	| Guia de princípios ativos visualizados com sucesso.
|Resultado obtido	|  Página de ativos visualizada com sucesso.
| Avaliação (pegou / não pegou erro)	| Sem erros
|Evidência (print screen) |  ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/2dadb75a-8061-4f25-bd83-691273ccb72d)


<br><br>


# Registro de Testes Regras de negócio


|     Caso de teste     |   CT-01 – Cadastro a partir de 16 anos                                                                                                  
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|01 |O cadastro de novos usuários será finalizado somente após o preenchimento de todos os campos obrigatórios, e a confirmação de que o usuário possui no mínimo 16 anos de idade.|
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar com idade inferior a 16 anos. |
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3-	Acessar login e clicar em cadastro. <br> 4-	Preencher todos os campos, e na data de nascimento selecionar o ano atual, ou outro de sua escolha, onde a idade  seja inferior a 16 anos. <br> 5- Clicar no botao cadastrar.
| Resultado esperado	|Um alerta aparece na tela, informando que o usuário deve ter 16 anos ou mais para se cadastrar no site..
|Resultado obtido	|  Uma mensagem aparece na tela, e o usuário nao consegue efeturar o cadastreo sendo menor de 16 anos.
| Avaliação (pegou / não pegou erro)	| Sem erros
|Evidência (print screen) | Tentativa de cadastro utilizando o ano atual no campo data de nascimento  ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6333b275-5405-4a1f-8286-d4f3bdbc1573)  <br> <br> Ao clicar em cadastrar, o alerta aparece na tela, e o cadastro não é efetuado. ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/9a8ab76f-fd20-45f4-b8fb-b693a33751c3)


<br><br>
