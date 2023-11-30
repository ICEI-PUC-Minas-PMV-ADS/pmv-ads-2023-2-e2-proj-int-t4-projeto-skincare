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


<br>  
Evidência (vídeo): Ao fazer login com uma conta de usuário padrão, a opção "Minha Conta" é exibida na barra de navegação.
<br> <br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/97e18a65-b2b9-406e-8b51-116dad20a62d 

 <br><br>  
 
Evidência (vídeo): Ao fazer login com uma conta de administrador, a opção "Administrador" é exibida na barra de navegação.
 <br>  <br>  

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/eb867270-2c12-47e6-9b03-6336c81ea2bb



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

<br>
Evidência (vídeo): Teste cadastro do usuário
 <br><br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/a636ab9b-c9fb-477e-b3a5-f08274eb86e3



<br><br>


|     Caso de teste     | CT- 03  – Criar rotina ao responder um questionário                                                                                                                                                       
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados | RF-003, RF-011: 	O sistema deve ser capaz de criar rotinas personalizadas de skincare ao responder um questionário, utilizando a api do OpenAI. <br>  RF-013 O sistema deve conter um questionário com perguntas detalhadas para entender as necessidades dos usuários.                                                                                               |
|   Objetivo do Teste   |  Verificar se o usuário consegue gerar sua rotina personalizado ao responder o questionário.                                                                                                                     |
| Passos 	| 1- Acessar o navegador <br> 2- Informar o endereço do site.<br> 3- Fazer 'login' no site  <br>  4- Clicar em ‘Quiz da pele’  <br>  4- Responder questionário  <br> 5- Clicar em ver minha rotina |
| Resultado esperado	| Rotina personalizada é mostrada na tela para o usuário
|Resultado obtido	|  Rotina criada com sucesso. 
| Avaliação (pegou / não pegou erro)	| Não possui erros. 	| 
<br><br>
  
 Evidência (vídeo): Teste responder o questionário e visualizar rotina personalizada.
 
**Observação: A rotina é gerada por meio de uma requisição à API do Chat GPT, sendo assim, ela pode levar alguns segundos. Recomendamos que avance o vídeo durante esse processo.**
<br><br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/f53fae15-ca2a-4c98-b5a5-2fc64db7d0f6

<br><br>

|     Caso de teste     | CT-04 – Recomendação médica	                                                                                                                                                 
| :-------------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
|Requisito Associado | RF-004	- O sistema deve incluir uma mensagem automática no final do questionário, recomendando que o usuário procure um profissional de saúde, caso identifique que seu problema de pele requer cuidados médicos . |
| Objetivo do Teste 	| Verificar e identificar se o usuário necessita procurar ajuda médica. |
| Passos 	| 1- Acessar o navegador <br> 2 - Informar o endereço do site.<br> 3 - Clicar em  Quiz da pele na 'Home page'<br>  4 - Responder ao ‘Questionário’ <br>  4 -Responder "Sim" para a pergunta número 3 |
| Resultado esperado	|  É recomendado que procure ajuda médica. 
|Resultado obtido	|  Ao selecionar a resposta "Sim" para a pergunta 3, a rotina nao é gerada, e o alerta com a mensagem aparece na tela.
| Avaliação (pegou / não pegou erro)	| Sem erros

Evidência (vídeo) - Teste ao responder "Sim" para a pergunta número 3 do questionário.
<br><br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/7b8ae294-6c40-42e2-aba0-a9e0d8579bb8

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
| Passos 	| 1-	Acessar o navegador <br> 2- Informar o endereço do site. <br> 3- Fazer o login no sistema <br> 4- Clicar em "Quiz da pele" na ‘Home page’ <br> 5- Responder questionário |
| Resultado esperado	|  A rotina para cada problema específico de pele será gerada com sucesso. 
|Resultado obtido	|  Uma rotina para cada problema específico de pele foi gerada com sucesso. 
| Avaliação (pegou / não pegou erro)	| Sem erros
|Evidência (print screen) |  Rotina pele fumante  <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/851fe092-49cd-4c3c-a8e6-1e05739f4c3f) <br> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/ebac47cb-b32b-4dff-9f5e-32efc3df1066) <br><br> Pele com rugas ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/e685ad7f-1eb5-4a18-b3a1-56eec4458fd2) ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/bf8e044b-297a-4bc2-a4da-caf9108ce410) <br> <br>  Pele com melasma ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/164fecbd-6154-43d8-a4c7-9d9e00578712) ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/5fba2d0c-2dee-48e6-9591-bdf8a6700a15)




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
<br><br>


Evidência (vídeo): Teste efetuado ao cadastrar uma idade inferior a 16 anos.
<br><br>

https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/4e5ee9b1-1f43-4390-a209-babd14ad10b2



