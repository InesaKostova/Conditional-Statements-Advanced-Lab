double ages = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

if (gender == 'm')
{if (ages < 16)
    {
        Console.WriteLine("Master");
    }
    else
    {
        Console.WriteLine("Mr.");
    }
}
else if (gender =='f')
{ if (ages < 16)
    {
        Console.WriteLine("Miss");
    } 
else
    {
        Console.WriteLine("Ms.");
    }
 }
