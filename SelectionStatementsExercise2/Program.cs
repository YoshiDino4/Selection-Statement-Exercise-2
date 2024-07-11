namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Wow! Look at you, mathematician!");
                    break;
                case "science":
                    Console.WriteLine("Wow! Look at you, scientist!");
                    break;
                case "english":
                    Console.WriteLine("Wow! Look at you, author!");
                    break;
                case "art":
                    Console.WriteLine("Wow! Look at you, artist!");
                    break;
                case "history":
                    Console.WriteLine("Wow! Look at you, historian!");
                    break;
                default:
                    Console.WriteLine($"Wow! Good for you, {subject} sounds interesting!");
                    break;
                    
            }
        }
    }
}