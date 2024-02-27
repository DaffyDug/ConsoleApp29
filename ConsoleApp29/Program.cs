namespace HW_6_
{
    using System;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            string stringtext = "";
            InputText inputText = new InputText();
            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. введение текста");
                Console.WriteLine("2. вывод на экран");
                Console.WriteLine("3. очистить текст");
                Console.WriteLine("4. замена строк");
                Console.WriteLine("5. очистить экран");
                Console.WriteLine("6. закрыть программу");
                string intvalue = Console.ReadLine();
                if (intvalue == "1")
                {
                    inputText.inputtext(stringtext, stringBuilder);
                }
                if (intvalue == "2")
                {
                    inputText.outputtext(stringBuilder);
                }
                if (intvalue == "3")
                {
                    inputText.Clear_text(stringBuilder);
                }
                if (intvalue == "4")
                {
                    inputText.Replace_text(stringBuilder);
                }
                if (intvalue == "5")
                {
                    inputText.Clear_scr();
                }
                if (intvalue == "6")
                {
                    break;
                }
            }
        }
    }
}