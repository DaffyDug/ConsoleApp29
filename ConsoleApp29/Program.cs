using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string stringtext = "";
        InputText inputText = new InputText(stringtext);
        StringBuilder stringBuilder = new StringBuilder();
        while (true)
        {
            Console.WriteLine("1. введение текста");
            Console.WriteLine("2. вывод на экран");
            Console.WriteLine("3. очистить текст");
            Console.WriteLine("4. замена строк");
            Console.WriteLine("5. очистить экран");
            string intvalue = Console.ReadLine();
            if (intvalue == "1")
            {
                string txt = inputText.inputtext(stringtext);
                while (true)
                {
                    Console.WriteLine("1. Write");
                    Console.WriteLine("2. WriteLine");
                    string intvalue2 = Console.ReadLine();
                    if (intvalue2 == "1" || intvalue2 == "2")
                    {
                        if (intvalue2 == "1")
                        {
                            stringBuilder.Append(txt);
                        }
                        if (intvalue2 == "2")
                        {
                            stringBuilder.Append("\n" + txt);
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ошибка");
                    }
                }
            }
            if (intvalue == "2")
            {
                if (stringBuilder.Length > 0)
                {
                    inputText.outputtext(stringBuilder);
                }
                else
                {
                    Console.WriteLine("ошибка");
                }
            }
            if (intvalue == "3")
            {
                if (stringBuilder.Length > 0)
                {

                    Console.WriteLine("вы точно хотите удалить текст?");
                    Console.WriteLine("1. да");
                    Console.WriteLine("2 или любая другая цифра. нет");
                    string intvalue3 = Console.ReadLine();
                    if (intvalue3 == "1")
                    {
                        inputText.Clear_text(stringBuilder);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("нельзя удалить то чего нет");
                }
            }
            if (intvalue == "4")
            {
                if (stringBuilder.Length > 0)
                {
                    Console.WriteLine(stringBuilder);
                    Console.WriteLine("какие строки вы хотите заменить ?");
                    string str = Console.ReadLine();
                    Console.WriteLine("на какие стоки вы хотите заменить?\n");
                    string str2 = Console.ReadLine();
                    Console.WriteLine($"вы хотите заменить {str} на {str2} \n все верно ? \n 1. да 2.нет \n");
                    string str3 = Console.ReadLine();
                    if (str3 == "1")
                    {

                        if (stringBuilder.ToString().Contains(str))
                        {
                            stringBuilder.Replace(str, str2);
                            Console.WriteLine(stringBuilder);
                        }
                        else
                        {
                            Console.WriteLine("таких строк либо нет, либо мы не можем заменить на эти строки");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            if (intvalue == "5")
            {
                inputText.Clear_scr();
            }
        }
    }
}