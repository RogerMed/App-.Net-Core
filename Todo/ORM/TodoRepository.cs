using Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Linq;

namespace ORM
{
    public class TodoRepository : RepositoryConnector, Interfaces.ITodoRepository
    {


        public TodoRepository(IConfiguration config) : base(config)
        {

        }

        public void add(ToDo obj)
        {
            DynamicParameters pam = new DynamicParameters();
            pam.Add("@Tarefa", obj.Tarefa);

            string sql = "INSERT INTO Todo (Tarefa) VALUES (@Tarefa)";
            using (var con = new SqlConnection(base.GetConection()))
            {
                con.Execute(sql, pam);
            }

        }

        public ToDo Get(int id)
        {
            string sql = $"SELECT * FROM Todo Where Id = {id}";
            using (var con = new SqlConnection(base.GetConection()))
            {
                return con.Query<ToDo>(sql).FirstOrDefault();
            }
        }
        public ToDo Get(ToDo obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAll()
        {
            IEnumerable<ToDo> retorno;
            string sql = "SELECT * FROM Todo";
            using (var con = new SqlConnection(base.GetConection()))
            {
                retorno = con.Query<ToDo>(sql);
            }
            return retorno;
        }

        public void Revome(ToDo obj)
        {
            string sql = $"Delete  FROM Todo WHERE Id ={obj.id}";
            using (var con = new SqlConnection(base.GetConection()))
            {
                con.Execute(sql);
            }
        }

        public void Update(ToDo obj)
        {
            string sql = $"UPDATE Todo SET tarefa = @Tarefa WHERE Id = {obj.id}";

            DynamicParameters pam = new DynamicParameters();
            pam.Add("@Tarefa", obj.Tarefa);

            using (var con = new SqlConnection(base.GetConection()))
            {
                con.Execute(sql, pam);
            }
        }

    }
}
