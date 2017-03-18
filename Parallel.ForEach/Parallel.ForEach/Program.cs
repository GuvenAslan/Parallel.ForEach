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

    public static class Program
    {
        public static void Main(string[] args)
        {
            List<User> _users = FillUsers();
            List<City> _cities = FillCities();
            RunForeach(_users, _cities);
            Console.ReadKey();
        }

        public static bool RunForeach(List<User> _users, List<City> _cities)
        {
            System.Threading.Tasks.Parallel.ForEach(_users, (currentFile) => Console.WriteLine(currentFile.Name + ", " + _cities.FirstOrDefault(x => x.UserID == currentFile.UserID).Name));
            return true;
        }
        public static List<User> FillUsers()
        {
            var _users = new List<User>();
            for (int i = 0; i < 50; i++)
                _users.Add(new User { UserID = i, Name = i.ToString() + ". Name" });
            return _users;
        }
        public static List<City> FillCities()
        {
            var _cities = new List<City>();
            for (int i = 0; i < 50; i++)
                _cities.Add(new City { UserID = i, Name = i.ToString() + ". Name" });
            return _cities;
        }
    }

}