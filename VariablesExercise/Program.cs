namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string lastName = "Bond";
            char initial = 'J';
            int numMovies = 27;
            bool beingProduced = true;
            double totalTickets = 500;
            decimal totalGrosses = 7000000000.00m;



            Console.WriteLine($"My name is {lastName}, and my first inital is {initial}.");
            Console.WriteLine($"I have had {numMovies} movies made about my character.");
            Console.WriteLine($"My films have sold an estimated {totalTickets} million tickets and grossed over {totalGrosses} dollars.");
            Console.WriteLine($"Are my movies still being produced? {beingProduced}.");
        }
    }
}
