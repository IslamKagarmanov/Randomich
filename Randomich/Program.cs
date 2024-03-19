using System;

class randomich
{
    static void Main()
        
    {
        Random rnd = new Random();

        int ocenca = rnd.Next(2, 6);
        if ( ocenca == 2 ) 
        {
            Console.WriteLine("Неуд");
        }
        if (ocenca == 3)
        {
            Console.WriteLine("Удовл");
        }
        if (ocenca == 4)
        {
            Console.WriteLine("Хор");
        }
        if (ocenca == 5)
        {
            Console.WriteLine("Отл");
        }
    }
    
}

