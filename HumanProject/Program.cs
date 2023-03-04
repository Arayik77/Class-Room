namespace HumanProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string personName = Console.ReadLine();

            Console.WriteLine("Enter Surname");
            string personSurname = Console.ReadLine();

            //Human human = new Human();
            string checkname = Human.PersonName(personName);
            string checksurname = Human.PersonSurname(personSurname);
        }
    }
}