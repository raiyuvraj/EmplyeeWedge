// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main(string[] args)
    {
        int Full_Time = 1;
        int Part_Time = 2;
        int Wedge_Rate = 20;
        int EmpHours = 0;
        int EmpWedge = 0;
        Random random = new Random();
        int EmpCheck = random.Next(0,3);
        if (EmpCheck == Full_Time)
        {
            EmpHours = 8;
        }
        else if (EmpCheck == Part_Time)
        {
            EmpHours = 4;
        }
        else
        {
            EmpHours = 0;
        }
        EmpWedge = EmpHours * Wedge_Rate;
        Console.WriteLine("Employee Daily Wage : " + EmpWedge);
    }
 
}