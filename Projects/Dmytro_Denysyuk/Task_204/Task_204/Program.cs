int number,sum;
while (true)
{ 
    sum = 0;
    try
    {
        Console.WriteLine("Input number a<100:");
        number = Convert.ToInt32(Console.ReadLine());
       if(number<100 && number > 0)
        {
            char[] charArr = number.ToString().ToCharArray(); 
            foreach (char ch in charArr)
                sum+=Convert.ToInt32(ch.ToString());
            Console.WriteLine("Size: " + charArr.Length);
            Console.WriteLine("Sum: " + sum);
        }
        else
            Console.WriteLine("Error: Size numbert not correct");
    }
    catch (FormatException e)
    {
        Console.WriteLine("Error: " + e.Message);
    }
}
