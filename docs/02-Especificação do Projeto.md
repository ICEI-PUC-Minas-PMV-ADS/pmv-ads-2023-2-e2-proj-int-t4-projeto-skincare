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

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.


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
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t4-projeto-skincare/assets/93337008/543fe595-166f-49c0-a2ce-b818b4fd4364)





