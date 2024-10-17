namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 8;

            Console.WriteLine(answer < 9 ? $"{answer} is less then 9" : $"{answer} Is greater than or equal to 9" );
        }
    }
}
