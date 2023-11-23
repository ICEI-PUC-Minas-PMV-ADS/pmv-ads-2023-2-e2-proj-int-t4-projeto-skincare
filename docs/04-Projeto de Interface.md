
# Projeto de Interface

Dentre as preocupações para a montagem da interface do sistema, estamos estabelecendo foco em questões como agilidade, acessibilidade e usabilidade. Desta forma, o projeto tem uma identidade visual padronizada e atrativa em todas as telas que são projetadas para funcionamento em desktops e dispositivos móveis.

## Diagrama de Fluxo

No Fluxo a seguir, é mostrado passo a passo como é realizada a navegação e utilização das funcionalidades do site. 

1- Usuário acessa nosso site.

2- Ao clicar no "ícone de usuário" na página inicial, o usuário é redirecionado para a página de login, onde deverá inserir seu e-mail e senha.

3- Se o usuário não possuir cadastro, deve clicar em "Cadastre-se" na página de login. Para finalizar o cadastro, é necessário ter mais de 16 anos.

4- Após concluir o login ou cadastro, o usuário é redirecionado para a página inicial. O ícone do usuário desaparece, sendo substituído pelo botão "Minha Conta" e "Sair", indicando que está logado no sistema.

5- Na página inicial, o usuário deve clicar no botão "Quiz da Pele" para responder o questionário. O questionário contém perguntas para identificar as necessidades de cuidados com a pele, bem como possíveis problemas de pele mais graves. Se as respostas indicarem um problema mais grave, o usuário recebe um aviso na tela para procurar ajuda médica. Se as respostas forem negativas, a rotina é gerada.

6- O usuário visualiza a tela com a rotina gerada, contendo cuidados para a parte da manhã e noite.

7- Se o usuário desejar visualizar novamente sua rotina, deve retornar à página inicial, clicar em "Minha Conta" e poderá visualizá-la ou excluí-la conforme desejar.

8- Além disso, o usuário pode acessar diversas dicas sobre skincare clicando nos vários cards de informações na página inicial.



![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/a9a49d45-bb70-4652-94eb-12382c10cbae)


*figura 2- Fluxograma*

## Wireframes

Conforme fluxo de telas do projeto, apresentado no item anterior, as telas do sistema são apresentadas em detalhes nos itens que se seguem. 
As telas do sistema apresentam uma estrutura comum que é apresentada na Figura abaixo, na qual fora criado para o projeto anterior. O layout é composto pelo que se segue:

- **Cabeçalho**- Local onde são dispostos elementos fixos de identidade como o logo, e a navegação principal do site (menu da aplicação); 
- **Conteúdo**-  Apresentará, para cada tela, seu conteúdo personalizado;
- **Rodapé** -  Contém informações sobre direitos autorais, newsletter e social media.

![estrutua-padrao](https://user-images.githubusercontent.com/93337008/232315869-01305876-2750-4d61-9b16-63a0b154256b.PNG)

*figura 3 - Estrutura padrão do site*


### Tela: Home-page 

A tela que se segue compõe as principais funções do site de forma demonstrativa e objetiva para o usuário. 
A tela contém os campos:
- **Login** -  Permite que o usuário crie sua conta para acessar suas informações salvas e diretrizes do site. 
- **Criar Rotina** - A partir da criação da conta do usuário, é disponibilizado o campo para geração de rotina para o seu tratamento individual.
- **Tela de conteúdo informativo** - Cards informativos com dicas e conteúdos explicativos sobre skincare. 

![Home-page](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/fa79aba2-26c0-44e7-b231-c303e1580ae9)

*figura 4 - Home page do site* 



### Tela- Login e cadastro 

A tela de Login, apresenta para o usuario os campos necessários para acessar a sua conta. Caso ainda não a tenha criada, é indicada a mensagem para criação de conta e direcionada para a tela de cadastro. 

![tela login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/0c59cf81-ec43-4c5b-b3c3-1503e09a051d)

*figura 5 - Tela Login* 

Conforme imagem apresentada após a tela de login, a tela de cadastro apresenta os campos:


![Tela cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/1fb459db-8ac3-4736-a028-9c787524f1d4)

*figura 6 - Tela cadastro*

- **Email** - É solicitado para o usuário que preencha o canpo com seu email. 
- **Nome de usuário** - é indicado para o usuário que preencha o campo com seu nome social.
- **Data de nascimento** - é solicitado para o usuário sua data de nascimento, para que seja verificado se o mesmo possui mais de 16 anos. Conforme solicitado pelos termos de uso do site.
- **Senha** - é solicitada a criação de uma senha para acesso as suas informações armazenadas no site.



### Tela - Questionário

A tela questionário apresenta um quiz, no qual o usuário irá preencher com a as informações sobre sua saúde da pele, para que essas informações sejam salvas e gerada a rotina específica. 

![Quiz-da-pele](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/b87b6b84-c334-4729-beab-703dd713bfa5)

*figura 7 - Tela questionário*



### Tela - Rotina Gerada

Após a criação da conta e preenchimento do questionário, é exibida na tela a rotina personalizada para cada usuário de acordo com seu tipo de pele. 


![ROTINA-GERADA_1](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/57b33f52-befe-4cd0-86e8-5fc23ad7c65a)

*figura 8 - Tela Rotina gerada*


## Tela - Informação Ativos

Ao clicar no card de "O que são ativos?', o usuário será direcionado para a página de informações sobre os ativos e demais cuidados com a pele.

![atIVOS](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/c1b1dbad-c4df-486c-bdb5-37dc923760d0)

*figura 9 - Informação ativos*


## Tela - Minha conta 

Ao clicar em "Minha conta" e feito login, é exibida o setor de cadastro do usuário, onde exibe suas rotinas geradas e caso desejar, poderá excluí-las.
Também é exibido botão de "Sair" onde realiza o Logout da conta. 

![Tela minha conta](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/d40bcec2-2a79-463f-b7b9-c26b8ea96676)

*figura 10 - Minha conta*

