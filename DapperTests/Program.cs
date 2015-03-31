using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace DapperTests
{
    class Program
    {
        static void Main(string[] args)
        {
            DogRepository db = new DogRepository();
            
            /*Dog newDog = new Dog();
            newDog.Name = "Rambo";
            newDog.Age = 4;
            newDog.Weight = 20.32f;
            Console.WriteLine("connection state before command: " + db.DB.State);
            db.Create(newDog);
            Console.WriteLine("connection state after command: " + db.DB.State);*/

            var allDogs = db.GetAll();
            foreach(var dog in allDogs)
            {
                Console.WriteLine("Name: " + dog.Name + " Age: "+ dog.Age + ", Weight: " + dog.Weight);
            }

            Console.ReadLine();
        }
    }
}
