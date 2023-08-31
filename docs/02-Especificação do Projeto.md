# Especificações do Projeto


As pesquisas para embasamento e desenvolvimento da historias que dão origem ao projeto, foram retiradas da internet, onde analisamos e obtivemos os resultados a cerca do assunto a ser tratado. 
Para criação das personas/publico-alvo, foram decididos os detalhes através de debates com os membros da equipe e as pesquisas que foram feitas. 


## Personas


|Jéssica Rodrigues  | Informações:                          | **Tipo de pele:**                          |     
|--------------------|----------------------------------|--------------------------------------|
| <img width="346" alt="Capture" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6211ff70-c9c9-4008-84a8-63dc3a145ba1"> | **Idade:** 26 <br> **Ocupação:** Estudante e estagiária. Atualmente cursando psicologia e estagiando em uma empresa privada.  |<br>● Eudérmica a seca      |
|**Frustações:** <br>●	Preocupação com envelhecimento <br>●Manchas na pele |**Desafios:** <br>●	Orçamento limitado e falta de tempo. |**Hobbies,História:** <br>● Jéssica, uma jovem adulta de 26 anos, possui uma rotina cheia, com uso intenso de maquiagem e com pouco tempo livre para cuidados consigo mesma. Devido a isso, a mesma busca uma forma de iniciar seus cuidados com a pele visto que isso a incomoda.  |


|Nome | Informações:                          | **Tipo de pele:**                          |     
|--------------------|----------------------------------|--------------------------------------|
| <img width="346" alt="Capture" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6211ff70-c9c9-4008-84a8-63dc3a145ba1"> | **Idade:**  <br> **Ocupação:**   |<br>●      |
|**Frustações:** <br>●	 <br>● |**Desafios:** <br>●	 |**Hobbies,História:** <br>●   |


|Nome | Informações:                          | **Tipo de pele:**                          |     
|--------------------|----------------------------------|--------------------------------------|
| <img width="346" alt="Capture" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6211ff70-c9c9-4008-84a8-63dc3a145ba1"> | **Idade:**  <br> **Ocupação:**   |<br>●      |
|**Frustações:** <br>●	 <br>● |**Desafios:** <br>●	 |**Hobbies,História:** <br>●   |


|Nome | Informações:                          | **Tipo de pele:**                          |     
|--------------------|----------------------------------|--------------------------------------|
| <img width="346" alt="Capture" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6211ff70-c9c9-4008-84a8-63dc3a145ba1"> | **Idade:**  <br> **Ocupação:**   |<br>●      |
|**Frustações:** <br>●	 <br>● |**Desafios:** <br>●	 |**Hobbies,História:** <br>●   |


|Nome | Informações:                          | **Tipo de pele:**                          |     
|--------------------|----------------------------------|--------------------------------------|
| <img width="346" alt="Capture" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/6211ff70-c9c9-4008-84a8-63dc3a145ba1"> | **Idade:**  <br> **Ocupação:**   |<br>●      |
|**Frustações:** <br>●	 <br>● |**Desafios:** <br>●	 |**Hobbies,História:** <br>●   |



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |




## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve incluir uma página de login | ALTA | 
|RF-002| O site deve conter uma área para fazer cadastro de novos usuários   | ALTA |
|RF-003| O site deve conter um questionário com perguntas sobre o tipo de pele do usuário e suas preferencias   | ALTA |
|RF-004| O site deve gerar uma rotina de skincare de acordo com as informações obtidas no questionário   | ALTA |
|RF-005| A aplicação deve permitir que o usuário favorite os produtos de sua escolha   | MÉDIA |
|RF-006| A aplicação deve incluir no perfil do usuário uma lista de produtos marcados como favorito   | MÉDIA |
|RF-007| A aplicação deve exibir uma imagem correspondente a cada produto indicado.  | MÉDIA |
|RF-008| A aplicação deve permitir que o usuário desfavorite seus produtos   | MÉDIA |
|RF-009| A aplicação deve incluir no perfil do usuário todas as rotinas geradas   | MÉDIA |
|RF-010| A aplicação deve permitir que o usuário delete suas rotinas   | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet ([Repl.it](http://repl.it/), GitHub Pages, Heroku). | MÉDIA | 
|RNF-002| O site deve ser responsivo, adaptando-se automaticamente a diferentes tamanhos de tela e dispositivos móveis. |  ALTA | 
|RNF-003| O sistema deve ser multiplataforma – Windows, Linux e macOS. |  ALTA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). |  ALTA | 
|RNF-005| O sistema deve funcionar 24h por dia, todos os dias da semana. |  MÉDIA | 
|RNF-006| A aplicação deve implementar protocolos de segurança para proteger os dados pessoais dos usuários. |  ALTA | 
|RNF-007| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 
|RNF-008| A interface do usuário deve ser intuitiva e de fácil navegação, que permita aos usuários encontrarem facilmente os tópicos de interesse. |  ALTA | 




## Regras de negócio
A tabela a seguir apresenta as regras de negócio desse projeto.
|ID| Regras                                            |
|--|-------------------------------------------------------|
|01| O cadastro de novos usuários será finalizado somente após o preenchimento de todos os campos obrigatórios, e a confirmação de que o usuário possui no mínimo 16 anos de idade.|
|02| Cada usuário terá a capacidade de criar até 3 rotinas por mês. Após a criação das 3 rotinas, será necessário aguardar até o próximo mês para gerar mais.       |
|03| Os usuários podem incluir até 5 produtos na lista de favoritos. Para adicionar mais produtos, será preciso remover um item da lista, criando espaço para novas adições.  |



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend e Backend.|
|02| A equipe não deve subcontratar o desenvolvimento do trabalho.      |



## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/543fe595-166f-49c0-a2ce-b818b4fd4364)





