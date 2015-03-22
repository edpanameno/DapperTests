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
            using(DogRepository db = new DogRepository())
            {
                Dog newDog = new Dog();
                newDog.Name = "Rambo";
                newDog.Age = 4;
                newDog.Weight = 20.32f;
                db.Create(newDog);

                /*var allDogs = db.GetAll();
                Console.WriteLine("connection status before loop: " + db.DB.State.ToString());
                foreach(var dog in allDogs)
                {
                    Console.WriteLine("Name: " + dog.Name + " Age: "+ dog.Age + ", Weight: " + dog.Weight);
                }
                
                Console.WriteLine("connection status after loop: " + db.DB.State.ToString());*/
            }

            Console.ReadLine();
        }
    }
}
