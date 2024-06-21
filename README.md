# Sistema-de-Gerenciamento-de-Estados-de-Tarefas
<p>
  Este projeto consiste no desenvolvimento de um sistema de gerenciamento de tarefas em C#, utilizando o padrão de projeto State para gerenciar as mudanças de estado das tarefas. O sistema permite que as tarefas alterem seu estado entre Criado, Em Progresso, Concluído e Cancelado. Essas transições de estado são realizadas por meio de solicitações feitas na camada de controller, que atua como intermediária entre a interface do usuário e a lógica de negócios. O projeto é programado em inglês, garantindo uma maior acessibilidade e padronização para desenvolvedores em diferentes regiões. O uso do padrão State oferece uma forma flexível e organizada de gerenciar os diferentes estados das tarefas, promovendo uma manutenção mais fácil e uma melhor escalabilidade do código.
</p>

 ## 🚨 Modelagem do Sistema

### Padrão State
- Foi utilizado esse padrão para a criação dos estados da tarefas.
- Estados: Criado, Em Progresso, Completado, Cancelado.
- Classe Task com Id, Nome, Descricao.

### Endpoints RESTful
- POST /tasks (Cria a tarefa)
- Estados:
<br> GET /Task/{id} (Pesquisa)
<br> PUT /Task/{id}/Começar (Iniciar a tarefa)
<br> PUT /Task/{id}/Completo (Conclui a tarefa)
<br> PUT /Task/{id}/Cancelado (Cancela a tarefa)

### Persistência de Dados
- Foi utilizado o Entity Framework.

<hr/>


<br/>

## ☕ Para usar o Sistema de Gerenciamento de Estados de Tarefas

<br> 📌 Baixe ou clone esse repositório
<br> 📌 Utilize a IDE que você está acostumada(o) para acessar os códigos
<br> 📌 No terminal digite o comando para criar o banco de dados:

  ```
  update-database
  ```
### ⚠ Atenção 

<br> ❗ Caso você baixe ou clone o repositório, ele vem com uma migration própria. Imporntante que você apague as migrations e gere uma nova com o código:
```
  add-migration teste
--
  update-database
  ```

<hr/>
