using System;
using System.Diagnostics.Contracts;

int number = 567462090;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    { 
        counter1++; 
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
    
}

Console.WriteLine("W liczbie " + (number) + " jest:");
Console.WriteLine("liczb '0' jest " + counter0);
Console.WriteLine("liczb '1' jest " + counter1);
Console.WriteLine("liczb '2' jest " + counter2);
Console.WriteLine("liczb '3' jest " + counter3);
Console.WriteLine("liczb '4' jest " + counter4);
Console.WriteLine("liczb '5' jest " + counter5);
Console.WriteLine("liczb '6' jest " + counter6); 
Console.WriteLine("liczb '7' jest " + counter7); 
Console.WriteLine("liczb '8' jest " + counter8);
Console.WriteLine("liczb '9' jest " + counter9);


