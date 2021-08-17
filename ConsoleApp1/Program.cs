using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserDTO dto = new UserDTO()
            {
                FirstName = "Riyaz",
                LastName = "K",
                UserContactDTO = new ContactDTO()
                {
                    ContactNumber = "123",
                    ContactType = "Home"
                }
            };

            UserProfile profile = new UserProfile();
            User user = profile.Map(dto);
            Console.ReadLine();
        }
    }
}
