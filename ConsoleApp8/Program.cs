namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Filankes", "filankesov@gmail.com", "1AAAArweerf");
            Person person = new Person(23, "sdadsa", "dsadsa");
            Console.WriteLine(person);
            Console.WriteLine(user);
        }
     
    }
}