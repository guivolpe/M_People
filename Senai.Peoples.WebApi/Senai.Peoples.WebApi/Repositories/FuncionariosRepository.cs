using Senai.People.WebApi.Domains;
using Senai.People.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.People.WebApi.Repositories

{
    public class FuncionariosRepository : IFuncionariosRepository
    {
        private string StringConexao = "Data Source=LAB102501\\SALEEXPRESS; initial catalog=M_PEOPLES; user Id=sa; pwd=132";
        private string stringConexao;

        public void Delete(int Id)
        {

            throw new NotImplementedException();
        }

        public void Insert(FuncionariosDomains funcionario)
        {
            throw new NotImplementedException();
        }

        public List<FuncionariosDomains> SelectAll()
        {
            List<FuncionariosDomains> Funcionarios = new List<FuncionariosDomains>();

            using (SqlConnection connection = new SqlConnection(StringConexao))


            {
                string query = "SELECT ID_FUNCIONARIO, NOME, SOBRENOME FROM TBL_FUNCIONARIOS";

                connection.Open();

                SqlDataReader rdr;                                          //define o metodo de leitura

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    rdr = cmd.ExecuteReader();                              //chama o metodo rdr que esta dentro do cmd e faz a leitua
                    while (rdr.Read())
                    {
                        FuncionariosDomains funcionarios = new FuncionariosDomains              //cria um genero
                        {
                            ID_FUNCIONARIO = Convert.ToInt32(rdr[0]),
                            NOME = rdr["Nome"].ToString(),
                            SOBRENOME = rdr["Sobrenome"].ToString()
                        };

                        Funcionarios.Add(funcionarios);                               //adiciona na lista
                    }
                }
            }

            return Funcionarios;
            ///////////////////////////////////////////////////////////////////////////////////

             FuncionariosDomains SelectById(int id)
            {
                using (SqlConnection connection = new SqlConnection(StringConexao))
                {
                    string queryGetid = "Select * from Funcionarios WHERE idFuncionario = @ID"; connection.Open(); SqlDataReader rdr; using (SqlCommand cmd = new SqlCommand(queryGetid, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id); rdr = cmd.ExecuteReader(); if (rdr.Read())
                        {
                            FuncionariosDomains funcionario = new FuncionariosDomains()
                            {
                                IDFUNCIONARIO = Convert.ToInt32(rdr["idFuncionario"]),
                                NOME = rdr["Nome"].ToString(),
                                SOBRENOME = rdr["Sobrenome"].ToString()
                            };
                            return funcionario;
                        }
                        return null;
                    }

                }
            }
        }

        public FuncionariosDomains SelectById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

    
