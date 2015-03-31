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
        private string ConnectionString { get; set; }
        
        /// <summary>
        /// SqlConnection Object that is used to communicate with the
        /// database with.
        /// </summary>
        protected IDbConnection _db { get; set; }

        public AbstractRepository()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DapperTestsDB"].ConnectionString;
            _db = new SqlConnection(ConnectionString);
        }

        public abstract void Create(T obj);
        public abstract T Retrieve(int objectID);
        public abstract void Update(T obj);
        public abstract void Delete(int objectID);
        public abstract List<T> GetAll();
    }
}
