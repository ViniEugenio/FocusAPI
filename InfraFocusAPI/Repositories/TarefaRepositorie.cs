using DomainFocusAPI.Interfaces;
using DomainFocusAPI.Models;
using InfraFocusAPI.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfraFocusAPI.Repositories
{
    public class TarefaRepositorie : MainRepositorie<Tarefa>, ITarefaRepositorie
    {
        public TarefaRepositorie(Context context) : base(context)
        {
        }
    }
}
