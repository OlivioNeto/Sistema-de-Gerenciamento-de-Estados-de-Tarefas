using Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Model.Enum;

namespace Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Model
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StateTask State { get; set; }
    }
}
