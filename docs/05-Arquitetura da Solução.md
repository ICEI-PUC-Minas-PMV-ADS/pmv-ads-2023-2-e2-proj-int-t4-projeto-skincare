# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

<img width="992" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/375eaa1b-69d1-4f3b-92c5-4ba9a76ff5a0">

*<span style="font-size: 1px;">Figura 11 - Diagrama de classes</span>*


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/b0da5469-1e90-464e-8393-b4e5f4652223)


*Figura 12 - Modelo ER*


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

<img width="683" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/e4d84235-934e-4f09-bf4e-06a65657e78f">

*<font size="2"> Figura 13 - Base de dados </font>*

### Cardinalidade

**Usuário x Rotina de Skincare:**

Cada usuário pode ter uma ou várias rotinas de skincare (relação "um para muitos" - 1,N).

**Rotina de Skincare x Usuário:**

Cada rotina de skincare pertence a apenas um usuário, indicando uma relação de "um para um" (1,1).
<br>


**Usuário x  Questionário(perguntas)**
  
Cada usuário pode responder a um questionário de perguntas, indicando uma relação de "um para um" (1,1).


**Questionário x Usuário**
  
O questionário de perguntas  é respondido por vários usuários, indicando uma relação de "um para muitos" (1,N).
<br>


**Rotina de Skincare x Questionário(Perguntas):**

Cada rotina de skincare está ligada a um questionário de perguntas (relação "um para um" - 1,1).


**Perguntas do Questionário x Rotina de Skincare**

O questionário de perguntas  pertence a várias rotinas de skincare (relação "um para muitos" - 1,N).









## Tecnologias Utilizadas

IDE Visual Studio, linguagem de programação C#, Frameworks .NET e SQL Server para Banco de Dados.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.


