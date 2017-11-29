using System;
using System.Collections;
using System.Diagnostics;
class Program:Exception
{
    public static int Exception1(int x, int y)
    {
        if (y == 0)
        {
            Exception a = new Exception();
            a.Data.Add("Время возникновения: ", DateTime.Now);
            Console.WriteLine("Деление на 0 не возможно");
            throw a;
        }
        return x / y;
    }
    public static int Exception2(int x, int y)
    {

        if (y is double || x is double)
        {
            Exception a = new Exception();
            Console.WriteLine("Числа должны быть целыми");
            a.Data.Add("Время возникновения: ", DateTime.Now);
            throw a;
        }
        return x / y;
    }

    public static int Exception3(int[] x, int y)
    {

        if (x.Length < y || x.Length<=0)
        {
            Exception a = new Exception();
            Console.WriteLine("В массиве содержится только 10 элементов");
            throw a;
        }
        return y;
    }

    public static int Exception4(float y)
    {
        
        if (y>=2.5)
        {
            Exception a = new Exception();
            Console.WriteLine("Вы промахнулись");
            throw a;
        }
        return 0;
    }
    static void Main(string[] args)
    {
        int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        try
        {
            Console.WriteLine("Введите Делимое");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Делитель");
            int y = int.Parse(Console.ReadLine());
            Exception1(x, y);
            Exception2(x, y);
            var z = (float)x / y;
            Console.WriteLine("{0}/{1}={2}",x,y,z);
            Console.WriteLine("Введите индекс элемента массива, который нужно вывести");
            int k= int.Parse(Console.ReadLine());
            Exception3(b, k);
            Console.WriteLine("b[{0}]= {1}", k, b[k-1]);
            Console.WriteLine("Введите число меньше 2.5, но больше 12.322");
            float f = float.Parse(Console.ReadLine());
            //Debug.Assert(f >= 12.322);
            Exception4(f);
        }

        catch (IndexOutOfRangeException ex)
        {
            Console.Write(ex.Message + "\n");
            Console.Write(ex.TargetSite + "\n");
            if (ex.Data != null)
            {
                foreach (DictionaryEntry d in ex.Data)
                    Console.WriteLine(d.Value);
            }
        }

        catch (FormatException ex)
        {
            Console.Write(ex.Message + "\n");
            Console.Write(ex.TargetSite + "\n");
            if (ex.Data != null)
            {
                foreach (DictionaryEntry d in ex.Data)
                    Console.WriteLine(d.Value);
            }
        }
        catch { }
        finally { }
    }
}