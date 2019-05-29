using PrismaWEB.Utils.Querys;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ProjetoModeloDDD.Infra.Data.Repositories.Sistema
{
    public class QueryRepository : IQueryRepository
    {
        // string de conexao
        readonly string conexao = WebConfigurationManager.ConnectionStrings["ProjetoModeloDDD"].ConnectionString;

        public IList<QueryReseult> Get(string sql)
        {
            using (var conn = new SqlConnection(conexao))
            {
                var cmd = new SqlCommand(sql, conn);
                List<object> dados = new List<object>();
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        IList<QueryReseult> result = new List<QueryReseult>();
                        while (reader.Read())
                        {
                            QueryReseult queryResult = new QueryReseult();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                queryResult.AdicionarCampo(reader[i], reader.GetName(i));
                            }
                            result.Add(queryResult);
                        }
                        return result;
                    }
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
