using APiBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APiBoletim.Interfaces
{
    interface IAluno
    {
        List<Aluno> ListarTodos();
        Aluno BuscarPorId(int id);
        Aluno Cadastrar(Aluno a);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);

    }
}
