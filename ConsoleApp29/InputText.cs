using System;
using System.Text;

class InputText
{
    public string inputtext(string txt, StringBuilder _sb)
    {
        Console.Write("введиет текст: ");
        txt = Console.ReadLine();
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. WriteLine");
            string intvalue2 = Console.ReadLine();
            if (intvalue2 == "1" || intvalue2 == "2")
            {
                if (intvalue2 == "1")
                {
                    _sb.Append(txt);
                }
                if (intvalue2 == "2")
                {
                    _sb.Append("\n" + txt);
                }
                break;
            }
            else
            {
                Console.WriteLine("ошибка\n");
            }
        }
        return txt;
    }
    public void outputtext(StringBuilder _sb)
    {
        if (_sb.Length > 0)
        {
            Console.WriteLine("ваш текст: " + _sb + "\n");
        }
        else
        {
            Console.WriteLine("ошибка\n");
        }
    }
    public void Clear_text(StringBuilder _sb)
    {
        if (_sb.Length > 0)
        {
            Console.WriteLine("вы точно хотите удалить текст?");
            Console.WriteLine("1. да");
            Console.WriteLine("2. нет");
            string intvalue3 = Console.ReadLine();
            if (intvalue3 == "1")
            {
                _sb.Clear();
                Console.WriteLine("\n");
            }
        }
        else
        {
            Console.WriteLine("нельзя удалить то чего нет\n");
        }
    }
    public void Replace_text(StringBuilder _sb)
    {
        if (_sb.Length > 0)
        {
            Console.WriteLine(_sb);
            Console.WriteLine("какие строки вы хотите заменить ?");
            string str = Console.ReadLine();
            Console.WriteLine("на какие стоки вы хотите заменить?");
            string str2 = Console.ReadLine();
            Console.WriteLine($"вы хотите заменить '{str}' на '{str2}' \n все верно ? \n 1. да \n 2. нет \n");
            string str3 = Console.ReadLine();
            if (str3 == "1")
            {
                if (_sb.ToString().Contains(str))
                {
                    _sb.Replace(str, str2);
                    Console.WriteLine(_sb + "\n");
                }
                else
                {
                    Console.WriteLine("таких строк либо нет, либо мы не можем заменить на эти строки\n");
                }
            }
        }
        else
        {
            Console.WriteLine("нельзя изменить то чего нет\n");
        }
    }
    public void Clear_scr()
    {
        Console.Clear();
    }
}