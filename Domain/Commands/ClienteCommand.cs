using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
