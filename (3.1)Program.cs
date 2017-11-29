using System;

class SuperString
{
    readonly int length;
    public const int z=4;
    public string str;
    private char t;
    static int count = 0;
    private static string about = "Созданный класс нужен для работы со строками.";
    public void LengthOfTheString(string a, ref int k)
    {
        Console.WriteLine("Длина строки: '{0}' = '{1}'", a, a.Length);
    }
    public void IsThereSimbol(string a, string b, out char l)
    {
        l = 'u';
        bool c = a.Contains(b);
        Console.WriteLine("'{0}' есть в строке '{1}': {2}",b, a, c);
    }
    public void Change(string a, string b, string c)
    {
        Console.WriteLine("Начальная строка: '{0}'", a);
        a = a.Replace(b, c);
        Console.WriteLine("Строка после замены символа: '{0}'", a);
    }
    public static string GetInfo()
    {
        return about;
    }
    public SuperString() { count++; }
    public SuperString(int x) { count++; }
    public SuperString(char y) { count++; }
    static SuperString() { count++; }
    public string STR { get; set; }
    public char T { get; }
    //public ~SuperString()
    //{
    //    count--;
    //}
    //private SuperString() { }

}
class TestSuperString
{
   static void Main()
    {
        int o = 9;
        SuperString s = new SuperString();
        s.LengthOfTheString("I have a cat", ref o);
        Console.Write("Введите символ, который хотите найти: ");
        string s1 = Console.ReadLine();
        char p;
        s.IsThereSimbol("I have a cat", s1, out p);
        Console.WriteLine("Какой символ вы хотите заменить?");
        string s2 = Console.ReadLine();
        Console.WriteLine("На какой символ хотите заменить?");
        string s3 = Console.ReadLine();
        s.Change("I have a cat", s2, s3);

        Console.WriteLine();
        SuperString st = new SuperString();
        st.LengthOfTheString("You have a dog", ref o);
        Console.Write("Введите символ, который хотите найти: ");
        string s11 = Console.ReadLine();
        st.IsThereSimbol("You have a dog", s11, out p);
        Console.WriteLine("Какой символ вы хотите заменить?");
        string s22 = Console.ReadLine();
        Console.WriteLine("На какой символ хотите заменить?");
        string s33 = Console.ReadLine();
        st.Change("You have a dog", s22, s33);
        Console.WriteLine(SuperString.GetInfo());

        var v = new {
            Amount = 108, Message = "Hello"
        };
        Console.WriteLine(v.Amount + v.Message);
    }
}