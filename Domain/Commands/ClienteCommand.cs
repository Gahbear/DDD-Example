namespace Domain.Commands
{
    public class ClienteCommand
    {
        public int ClienteId {get; set;}
        public string ClienteNome { get; set;}
        public DateTime DataNascimento { get; set;} 
        public int Habilitacao { get; set;}
        public string Estado { get; set;}
    }
}
