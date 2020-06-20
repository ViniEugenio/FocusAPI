using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFocusAPI.Models
{
    public class Tarefa : BaseClass
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public DateTime HoraTermino { get; private set; }
    }
}
