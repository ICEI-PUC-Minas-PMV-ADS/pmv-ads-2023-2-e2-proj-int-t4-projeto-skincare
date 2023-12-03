# Arquitetura da Solução


![Captura de tela 2023-10-22 170022](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/110791034/5bcd0f7b-1506-4e42-86b5-3cf2da3f6458)



## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/1db6454c-2dbf-49b1-8ea7-5db8e4d10642)


*<span style="font-size: 1px;">Figura 11 - Diagrama de classes</span>*


## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/f9227d1d-ae2b-46e3-a860-8af05a035c08)



*Figura 12 - Modelo ER*


## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/3d3308a3-33e1-4c74-a0ca-9cdd2e1ad8d7)


*<font size="2"> Figura 13 - Base de dados </font>*

### Cardinalidade

**Usuário x Rotina de Skincare:**

Cada usuário pode ter uma ou várias rotinas de skincare (relação "um para muitos" - 1,N).

**Rotina de Skincare x Usuário:**

Cada rotina de skincare pertence a apenas um usuário, indicando uma relação de "um para um" (1,1).
<br>



## Modelo físico

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/5114d135-b646-4701-9c37-3acab04ca74d)



## Tecnologias Utilizadas

#### Backend: 

Framework: ASP.NET MVC <br>
View Engine: Razor View <br>
Linguagem de Programação: C# <br>


#### Frontend:

Estrutura e Estilo: HTML e CSS <br>
Interatividade: JavaScript <br>
Framework de Interface: Bootstrap <br>


#### Ferramentas:

IDE: Visual Studio <br>
Controle de Versão: Git <br>


#### Banco de Dados:

Sistema de Gerenciamento de Banco de Dados: MySQL <br>


## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.


