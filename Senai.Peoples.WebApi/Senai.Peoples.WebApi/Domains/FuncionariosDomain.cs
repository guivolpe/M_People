using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.People.WebApi.Domains

{
    public class FuncionariosDomains
    {

        public int IDFUNCIONARIO { get; set; }
        public string NOME { get; set; }
        public string SOBRENOME { get; set; }
        public int ID_FUNCIONARIO { get; internal set; }
    }
}
