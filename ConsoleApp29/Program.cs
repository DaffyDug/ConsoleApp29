using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
interface IDamageble
{
    void Damageble(float x);
}
class Player : IDamageble
{
    private float _heath;
    private void Die()
    {
        Console.WriteLine("aaaaaaaaaa");
    }
    public void Damageble(float x)
    {
        if (_heath <= 0)
        {
            _heath = 0;
            Console.WriteLine(_heath);
            Die();
        }
        else
        {
            _heath -= x;
            Console.WriteLine(_heath);
        }
    }
}
class Wall : IDamageble
{
    private float _heath;
    private void Die()
    {
        Console.WriteLine("tttttttttttttttxxxxxxxxxxx");
    }
    public void Damageble(float x)
    {
        if (_heath <= 0)
        {
            _heath = 0;
            Console.WriteLine(_heath);
            Die();
        }
        else
        {
            _heath -= x;
            Console.WriteLine(_heath);
        }
    }
}
class Car : IDamageble
{
    private float _heath;
    private void Die()
    {
        Console.WriteLine("cccccxxxxxrrrrr");
    }
    public void Damageble(float x)
    {
        if (_heath <= 0)
        {
            _heath = 0;
            Console.WriteLine(_heath);
            Die();
        }
        else
        {
            _heath -= x;
            Console.WriteLine(_heath);
        }
    }
}