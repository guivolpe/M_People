using Senai.People.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.People.WebApi.Interfaces
{
    interface IFuncionariosRepository
    {
        List<FuncionariosDomains> SelectAll();
        FuncionariosDomains SelectById(int Id);
    }






}
