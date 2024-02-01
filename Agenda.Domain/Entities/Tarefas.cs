using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agenda.Domain.Entities
{
    public class Tarefas
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tarefa { get; set; }

        [ForeignKey("Lista_Tarefas")]
        public int Lista_TarefasId { get; set; }
        public Lista_Tarefas? Lista_Tarefas { get; set; }


        public required string Nome { get; set; }
        public required string Detalhes { get; set; } 
        public enum Prioridade { Baixa, Média, Alta }
        public DateTime Prazo { get; set; }

    }
}
