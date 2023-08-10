class program
{
    static void Main(string[] args)
    {
        //For Loop
        for (int i = 1; i < 10; i++)
        {
            if (i == 5)
            {
                //break; //values form 1 to 5 printed
                continue;// values except 5 all other get printed in the loop
            }
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
}