public class Program{

    static void Main (string [] args){
try
{
    Console.WriteLine("Enter int number");
    var input = Console.ReadLine();
    int number = int.Parse(input);

    if ( number < 0 )
    {
        throw new Exception ("Invalid Number");
    }

        double result = Math.Sqrt(number);
        Console.WriteLine($"The square root is{result}");

}
catch (FormatException e)
{
        Console.WriteLine("Invalid number");
        
}
    }
}