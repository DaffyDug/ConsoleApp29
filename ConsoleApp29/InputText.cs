using System;
using System.Text;

class InputText
{
    private string _text;
    public InputText(string text)
    {
        _text = text;
    }
    public string inputtext(string txt)
    {
        Console.Write("введиет текст: ");
        txt = Console.ReadLine();
        return txt;
    }
    public void outputtext(StringBuilder stringBuilder)
    {
        Console.WriteLine(stringBuilder);
    }
    public void Clear_scr(StringBuilder stringBuilder)
    {
        stringBuilder.Clear();
        stringBuilder.Clear();
    }
}