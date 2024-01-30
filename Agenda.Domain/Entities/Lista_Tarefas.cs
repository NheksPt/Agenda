namespace Agenda.Domain.Entities
{
    public class Lista_Tarefas
    {
        public int Id { get; set; }
        public required string Tipo { get; set; }
        public required string Descrição { get; set; }
        public DateTime Criação { get; set; }
    }
   
}
