# Parallel.ForEach
A simple Parallel.ForEach example

using System;
using System.Collections.Generic;
using System.Linq;

namespace Parallel.ForEach
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    public class City
    {
        public int UserID { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<User> _userList = new List<User>();
            List<City> _cityList = new List<City>();
            for (int i = 0; i < 50; i++)
            {
                _userList.Add(new User { UserID = i, Name = i.ToString() + ". Name" });
                _cityList.Add(new City { UserID = i, Name = i.ToString() + ". Name" });
            }
            System.Threading.Tasks.Parallel.ForEach(_userList, (currentFile) => Console.WriteLine(currentFile.Name + ", " + _cityList.FirstOrDefault(x => x.UserID == currentFile.UserID).Name));
            Console.ReadKey();
        }
    }
}