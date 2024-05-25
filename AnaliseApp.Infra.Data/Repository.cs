using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseApp.Infra.Data
{
    public class Repository
    {
        private string _connectionString = "Data Source=hackathoncoti.database.windows.net;Initial Catalog=arcaclouddev-26cd5c5d06a3442be89b08db1f72fcf7;Persist Security Info=True;User ID=giom;Password=hackathon@2024;Encrypt=False";


        public Financeiro? GetById(Guid PessoaId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Financeiro WHERE PessoaId = @PessoaId";
                return connection.QueryFirstOrDefault<Financeiro>(query, new { PessoaId });
            }
        }

        public List<Financeiro> Get(DateTime dataInicio, DateTime dataFim)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = @"SELECT * 
                                FROM Financeiro 
                                WHERE DataEmissao >= @DataInicio AND DataEmissao <= @DataFim
                                ORDER BY DataEmissao DESC";

                return connection.Query<Financeiro>(query, new { DataInicio = dataInicio, DataFim = dataFim }).ToList();
            }
        }

    }
}
