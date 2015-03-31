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
            
            Dog newDog = new Dog();
            newDog.Name = "Izzy";
            newDog.Age = 8;
            newDog.Weight = 30.32f;
            db.Create(newDog);

            var allDogs = db.GetAll();
            foreach(var dog in allDogs)
            {
                Console.WriteLine("Name: " + dog.Name + " Age: "+ dog.Age + ", Weight: " + dog.Weight);
            }

            Console.ReadLine();
        }
    }
}
