using System;

public partial class Printer{}
class Army//класс-Контейнер
{
    public static int count = 0;
    private List<int> year = new List<int>();
    private List<Common> list = new List<Common>();
    private List<int> price = new List<int>();

    public List<Common> GetList
    {
        get
        {
            return this.list;
        }
        set
        {
            this.list = value;
        }
    }
    public List<int> GetYear
    {
        get
        {
            return this.year;
        }
        set
        {
            this.year = value;
        }
    }
    public List<int> GetPower
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
        }
    }
    public void Add(Common obj, int year, int price)
    {
        list.Add(obj);
        years.Add(year);
        this.power.Add(price);
        count++;
    }
    public void Delete(Common obj)
    {
        int count = list.IndexOf(obj);
        list.Remove(obj);
        years.RemoveAt(count);
        this.power.RemoveAt(count);
        count--;
    }
    public void Print()
    {
        int i = 0;
        foreach (Common item in this.list)
        {
            item.Print();
            Console.WriteLine(year[i]);
            Console.WriteLine(this.price[i]);
            i++;
            Console.WriteLine("-------------------");
        }
    }
    public void Count()
    {
        Console.WriteLine($"Количество боевых единиц - {count}");
    }
    
}
class Conteiner
{
    static void Main()
    {
        Army чел1 = new Army(98, 325);
        Army чел2 = new Army(98, 325);
        Console.WriteLine(чел1.GetPower());
    }
}