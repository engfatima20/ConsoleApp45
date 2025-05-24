namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num :");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation please :");
            char OP = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num :");
            int secondnum = int.Parse(Console.ReadLine());

            int result =0;
            bool valid = true;
            if ( OP == '+')
            {
                result = firstnum + secondnum;
            }
            else if (OP == '-')
            {
                result = firstnum - secondnum;
            }
            else if (OP == '*')
            {
                result = firstnum * secondnum;
            }
            else if (OP == '/')
            {
                if (secondnum != 0)
                {
                    result = firstnum / secondnum;
                } else
                {
                    Console.WriteLine("Error : Divide By Zero !");
                    valid = false;
                }
            }
            else if (OP == '%')
            { 
                if ( secondnum != 0) 
                {
                    result = firstnum % secondnum;
                } else
                {
                    Console.WriteLine("Error : Divide By Zero !");
                    valid = false;
                }
               
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                valid = false;
            }
            if (valid)
            {
                Console.WriteLine("Result = " + result);
            }

            
           
        }
    }
}
