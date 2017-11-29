using System;

namespace CDCollection
{
    class Information
    {
        private string name;
        private string surname;
        private string fathername;
        private string favouritefilm;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Fathername
        {
            get { return fathername; }
            set { fathername = value; }
        }
        public string Favouritefilm
        {
            get { return favouritefilm; }
            set { favouritefilm = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Information[] person = new Information[20];
            for (int i = 0; i < 3; i++)
            {
                person[i] = new Information();
                Console.WriteLine("Имя: ");
                person[i].Name = Console.ReadLine();
                Console.WriteLine("Фамилия: ");
                person[i].Surname = Console.ReadLine();
                Console.WriteLine("Отчество: ");
                person[i].Fathername = Console.ReadLine();
                Console.WriteLine("Любимый фильм: ");
                person[i].Favouritefilm = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Введите длину, и я выведу все строки с такой длиной");
            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                if (person[i].Name.Length == l)
                    Console.WriteLine(person[i].Name);
            }
            for(int i = 0; i < 3; i++)
            {
                if (person[i].Surname.Length == l)
                    Console.WriteLine(person[i].Surname);
            }
            for(int i = 0; i < 3; i++)
            {
                if (person[i].Fathername.Length == l)
                    Console.WriteLine(person[i].Fathername);
            }
            for(int i = 0; i < 3; i++)
            {
                if (person[i].Favouritefilm.Length == l)
                    Console.WriteLine(person[i].Favouritefilm);
            }


            Console.WriteLine("Введите слово, и я выведу список строк с этим словом");
            string l1 = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (person[i].Name == l1)
                    Console.WriteLine(person[i].Name);
            }
            for (int i = 0; i < 3; i++)
            {
                if (person[i].Surname == l1)
                    Console.WriteLine(person[i].Surname);
            }
            for (int i = 0; i < 3; i++)
            {
                if (person[i].Fathername == l1)
                    Console.WriteLine(person[i].Fathername);
            }
            for (int i = 0; i < 3; i++)
            {
                if (person[i].Favouritefilm == l1)
                    Console.WriteLine(person[i].Favouritefilm);
            }
        }
    }
}
