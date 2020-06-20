using DomainFocusAPI.DTO;
using DomainFocusAPI.Interfaces;
using DomainFocusAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceFocusAPI.Services
{
    public class TarefaService
    {
        private readonly ITarefaRepositorie _Repositorie;

        public TarefaService(ITarefaRepositorie repositorie)
        {
            _Repositorie = repositorie;
        }

        public void CadastrarTarefa(Tarefa model)
        {
            _Repositorie.Adicionar(model);
        }
    }
}
