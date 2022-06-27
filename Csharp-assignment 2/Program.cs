using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class assigemenet2
{
    static void Main(string[] args)
    {
        double rl, dbms, phyton, java, total;
        double per;
        string nm, div;

        Console.Write("\n\n");
        Console.Write("Calculate the total, percentage and division to take marks of three course:\n");
        Console.Write("-------------------------------------------------------------------------------");
        Console.Write("\n\n");


        Console.Write("Input the Roll Number of the student :");
        rl = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the Name of the Student :");
        nm = Console.ReadLine();

        Console.Write("Input  the marks of dbms : ");
        dbms = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of  phyton: ");
        phyton = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of java : ");
        java = Convert.ToInt32(Console.ReadLine());

        total = dbms + phyton + java;
        per = total / 3.0;
        if (per >= 60)
            div = "First";
        else
        if (per < 60 && per >= 48)
            div = "Second";
        else
            if (per < 48 && per >= 36)
            div = "Pass";
        else
            div = "Fail";

        Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
        Console.Write("Marks in dbms : {0}\nMarks in phyton : {1}\n java : {2}\n", dbms, phyton, java);
        Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
    }
}
