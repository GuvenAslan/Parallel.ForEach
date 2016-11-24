# Parallel.ForEach
A simple Parallel.ForEach example

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


    class Program
    {
        static void Main(string[] args)
        {
            List<User> _userList = new List<User>();
            List<City> _cityList = new List<City>();
            for (int i = 0; i < 50; i++)
            {
                _userList.Add(new User
                {
                    UserID = i,
                    Name = i.ToString() + ". Name"
                });
                _cityList.Add(new City
                {
                    UserID = i,
                    Name = i.ToString() + ". Name"
                });
            }
            System.Threading.Tasks.Parallel.ForEach(_userList, (currentFile) =>
            {
                Console.WriteLine(currentFile.Name + ", " + _cityList.Where(x => x.UserID == currentFile.UserID).FirstOrDefault().Name);
            });
            Console.ReadKey();
        }
    }
