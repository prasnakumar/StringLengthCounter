using System;

namespace StringLengthCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean option = true;


            while (option ) {
                Console.WriteLine("Enter option \n 1)To Find length of string \n 2)exit ");
              string   menu = Console.ReadLine();
                if (menu == "1")
                {

                    LengthHelper value = new LengthHelper();

                    Console.WriteLine("Enter string:");
                    string string_name = Console.ReadLine();

                    int length = value.findLength(string_name);
                    Console.WriteLine("Length of string :" + length);
                }
                else if(menu=="2") { Console.WriteLine("EXIT BYE......");
                    option = false;
                }
                else
                {
                    Console.WriteLine("Invalid option ");
                }
            }

        }
    }
}
