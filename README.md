# Sistema-de-Gerenciamento-de-Estados-de-Tarefas
<p>
  Este projeto consiste no desenvolvimento de um sistema de gerenciamento de tarefas em C#, utilizando o padrão de projeto State para gerenciar as mudanças de estado das tarefas. O sistema permite que as tarefas alterem seu estado entre Criado, Em Progresso, Concluído e Cancelado. Essas transições de estado são realizadas por meio de solicitações feitas na camada de controller, que atua como intermediária entre a interface do usuário e a lógica de negócios. O projeto é programado em inglês, garantindo uma maior acessibilidade e padronização para desenvolvedores em diferentes regiões. O uso do padrão State oferece uma forma flexível e organizada de gerenciar os diferentes estados das tarefas, promovendo uma manutenção mais fácil e uma melhor escalabilidade do código.
</p>

 ## 🚨 Requisitos do Sistema

### Padrão State
- Utilização do padrão State para estados de tarefas.
- Estados: Created, In Progress, Completed, Cancel.
- Classe Task com id, name, description.

### Endpoints RESTful
- POST /tasks (Cria a tarefa)
- Estados:
<br> PUT /tasks/{id}/start (Inicia a tarefa)
<br> PUT /tasks/{id}/complete (Conclui a tarefa)
<br> PUT /tasks/{id}/cancel (Cancela a tarefa)
<br> GET /tasks/{id} (Pesquisa)

### Persistência de Dados
- Utilização do Entity Framework.

<hr/>


<br/>

## ☕ Usando o Sistema de Gerenciamento de Estados de Tarefas

Para usar esse projeto, siga estas etapas:
<br> 📌 Baixe ou clone esse repositório
<br> 📌 Utilize a IDE que você está acostumada(o) para acessar os códigos
<br> 📌 No terminal digite o comando para criar o banco de dados:

  ```
  update-database
  ```
### ⚠ Atenção 

<br> ❗ O projeto já vem com uma migration de criação de banco, se não tiver digite os comandos para criar o banco de dados:
  ```
  add-migration teste
--
  update-database
  ```

<hr/>
