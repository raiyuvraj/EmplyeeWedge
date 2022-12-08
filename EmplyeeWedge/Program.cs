﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    public const int Full_Time = 1;
    public const int Part_Time = 2;
    public const int Wedge_Rate = 20;

    static void Main(string[] args)
    {
        int EmpHours = 0;
        int EmpWedge = 0;
        Random random = new Random();
        int EmpCheck = random.Next(0,3);
        switch  (EmpCheck)
        {
            case Full_Time:
                EmpHours = 8;
                break;
            case Part_Time:
                EmpHours = 4;
                break;
            default:
                EmpHours = 0;
                break;

        }
        EmpWedge = EmpHours * Wedge_Rate;
        Console.WriteLine("Employee Daily Wage : " + EmpWedge);
    }
 
}