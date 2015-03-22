using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperTests
{
    public class DogRepository : AbstractRepository<Dog>
    {
        public override void Create(Dog dog)
        {
            var sqlQuery = @"INSERT INTO Dogs([Name], [Age], [Weight]) 
                            VALUES (@Name, @Age, @Weight); 
                            SELECT CAST(SCOPE_IDENTITY() AS INT)";

            Console.WriteLine("DogRepository.Create Connection Status (before): " + DB.State);
           
            dog.DogID = DB.Query<int>(sqlQuery, dog).Single();
            
            Console.WriteLine("DogRepository.Create Connection Status (after): " + DB.State);
        }

        public override Dog Retrieve(int dogID)
        {
            throw new NotImplementedException();
        }

        public override void Update(Dog dog)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int dogID)
        {
            throw new NotImplementedException();
        }

        public override List<Dog> GetAll()
        {
            var dogs = DB.Query<Dog>("SELECT * FROM Dogs");
            return dogs.ToList();
        }
    }
}
