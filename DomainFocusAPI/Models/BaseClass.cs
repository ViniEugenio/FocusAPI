using System;
using System.Collections.Generic;
using System.Text;

namespace DomainFocusAPI.Models
{
    public abstract class BaseClass
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }         
    }
}
