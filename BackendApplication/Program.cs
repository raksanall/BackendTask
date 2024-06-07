namespace BackendApplication
{
    public class Program()
    {
        List<string> productlines = File.ReadAllLines("Tickets.txt").ToList();
        Flight flight1 = new Flight("Baki-Rusiya", new(12,12,2021), new TimeOnly(17, 30, 25), "Rusiya", 6);
        Flight flight2 = new Flight("Baki-America", new(01, 12, 2021), new TimeOnly(17, 30, 25), "America", 5);
        Flight flight3 = new Flight("Baki-Turkey", new(23, 06, 2021), new TimeOnly(17, 30, 25), "Turkey", 15);
        Flight flight4 = new Flight("Baki-France", new(12, 14, 2021), new TimeOnly(17, 30, 25), "France", 3);
        
        public List<User> UsersList { get; set; }
        static void Main(string[] args)
        {


            Console.WriteLine("1 for Register or 2 for Login");
            string input = Console.ReadLine();
            int choise;
            Users newUserList = new();
            bool isTrue = int.TryParse(input, out choise);
            if (isTrue)
            {
                if (choise == 1)
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    User newuser = new User(username, password);
                    newUserList.UserAdd(newuser);
                }
                else if (choise == 2)
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    foreach (var user in newUserList.Users)
                    {
                        if (user.Name == username && user.Password == password)
                        {
                            Console.WriteLine("Loginned succesfully");
                            while (true)
                            {
                                Console.WriteLine("Menyudan secin");
                                Console.WriteLine("1.Book Ticket");
                                Console.WriteLine("2.Search for Ticket");
                                Console.WriteLine("3.Flight Info");
                                Console.WriteLine("4.Cancel Flight");
                                Console.WriteLine("5.My Flights");
                                Console.WriteLine("6.Exit ");
                                break;

                            }
                            input = Console.ReadLine();
                            isTrue = int.TryParse(input, out choise);
                            if (isTrue)
                            {
                                switch (choise)
                                {
                                    case 6:
                                        return;

                                }









                            }



                        }
                    }








                }

            }




        }
    }
}