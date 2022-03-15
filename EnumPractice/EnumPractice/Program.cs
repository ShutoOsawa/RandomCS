using System;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int command = 1005;
            if(Enum.IsDefined(typeof(Commands),command)){
                Console.WriteLine(command);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

    public enum Commands:int
    {
        Command1 = 1001,
        Command2 = 1002,
        Command3 = 1003
    }


}
