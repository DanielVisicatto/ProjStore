using Dapper;
using Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private string Connection { get; set; }

        // Esse método faz com que possamos recuperar o arquivo de configuração da nossa connection String.
        public StoreRepository()
        {
            Connection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; // apelido para conexão entre colchetes
        }        

        public bool Insert(Store store)
        {
            var status = false;
            using (var db = new SqlConnection(Connection))
            {
                db.Open();
                db.Execute(Store.INSERT, store);// aqui que entra o Dapper, o Dapper é instalado no projeto Repositories e não na solution;
                status = true;
            }
            return status;
        }

        public List <Store> GetAll()
        {
            using (var db = new SqlConnection(Connection))
            {
                var stores = db.Query<Store>(Store.GETALL);
                return(List<Store>)stores;
            }
        }
    }
}