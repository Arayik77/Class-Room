using System.Security.Cryptography;

namespace HumanProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string personName = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string personSurname = Console.ReadLine();

            Human human = new Human();
            string checkname = human.PersonName(personName);
            string checksurname = human.PersonSurname(personSurname);
            string checknameValidation = human.PersonNameValidation(personSurname);
            //human.PersonSurnameValidation(personSurname);

            Console.WriteLine(checkname);
            Console.WriteLine(checksurname);
            Console.WriteLine(checknameValidation);
            //Console.WriteLine(checkSurnameValidation);

            try
            {
                if (b == "true")
                {
                    Console.WriteLine("nooo");
                }
                else
                {
                    Console.WriteLine("Yeees");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}