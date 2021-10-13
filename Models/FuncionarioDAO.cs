using System;
using System.Collections.Generic;
using System.Text;
using DS_SISPRE.Interface;
using DS_SISPRE.Database;

namespace DS_SISPRE.Models
{

    class FuncionarioDAO : IDAO<Funcionario>
    {
        private static Conexao conn;

        public FuncionarioDAO()
        {
            conn = new Conexao();
        }

        public void Delete(Funcionario t)
        {
            throw new NotImplementedException();
        }

        public Funcionario GetById(int id_func)
        {
            throw new NotImplementedException();
        }

        public void Insert(Funcionario t)
        {
            try
            {
                var query = conn.Query();
                query.CommandText = "INSERT INTO funcionario(nome_func, cpf_func, email_func, telefone_func, funcao_func)" +
                    "VALUES (@nome, @cpf, @email, @telefone, @funcao)";

                query.Parameters.AddWithValue("@nome", t.Nome);
                query.Parameters.AddWithValue("@cpf", t.CPF);
                query.Parameters.AddWithValue("@email", t.Email);
                query.Parameters.AddWithValue("@telefone", t.Telefone);
                query.Parameters.AddWithValue("@funcao", t.Funcao);


            }
            catch (Exception e)
            {
                throw e;
            }finally
            {
                conn.Close();
            }

        }

        public List<Funcionario> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Funcionario t)
        {
            throw new NotImplementedException();
        }
    }
}
