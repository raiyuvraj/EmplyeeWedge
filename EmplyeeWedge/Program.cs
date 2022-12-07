// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        int Full_Time = 1;
        Random random = new Random();
        int EmpCheck = random.Next();
        if (EmpCheck == 1)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }
    }
 
}