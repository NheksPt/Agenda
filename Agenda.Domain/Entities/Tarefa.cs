using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Domain.Entities
{
    public class Tarefa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tarefa_ { get; set; }

        [ForeignKey("Lista_Tarefas")]
        public int Lista_TarefasID { get; set; }
        public Lista_Tarefas? Lista_Tarefas { get; set; }
        public required string Defenição { get; set; }
        public DateTime Prazo { get; set; }
        public required string Prioridade { get; set; }

    }
}

