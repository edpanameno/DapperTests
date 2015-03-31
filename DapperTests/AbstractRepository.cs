using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperTests
{
    public abstract class AbstractRepository<T> 
    {
        protected IDbConnection _db { get; set; }

        public AbstractRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DapperTestsDB"].ConnectionString);
        }

        public abstract void Create(T obj);
        public abstract T Retrieve(int objectID);
        public abstract void Update(T obj);
        public abstract void Delete(int objectID);
        public abstract List<T> GetAll();
    }
}
