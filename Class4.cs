using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    abstract class Лаборатория : IValueOptions, IName
    {

        private string _name;
        private int _value;
        private string _requirements;

        public override string ToString()
        {
            return "Nazvanie PO: " + Name + " Stoimost: " + Value + " Trebovaniya: " + Requirements;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Requirements
        {
            get { return _requirements; }
            set { _requirements = value; }
        }

        public PO()
        {
            Name = "None";
            Value = 0;
            Requirements = "None";
        }

        public PO(string Poname, int Povalue, string Porequirements)
        {
            Name = Poname;
            Value = Povalue;
            Requirements = Porequirements;
        }

        public virtual void Vivod()
        {
            Console.WriteLine("Nazvanie PO: " + Name + " Stoimost: " + Value + " Trebovaniya: " + Requirements);
        }

        public void Lower(int a)
        {
            Value = Value - a;
            Console.WriteLine("New Value of " + Name + " " + "= " + Value);
        }

        public void Higher(int a)
        {
            Value = Value + a;
            Console.WriteLine("New Value of " + Name + " " + "= " + Value);
        }

        public string NameChange(string a)
        {
            Name = a;
            return Name;
        }

        public virtual void SAS()
        {
            Console.WriteLine("sas");
        }

    }

    class TextProcessor : PO, IValueOptions
    {
        int WriteSpeed { get; set; }

        public override string ToString()
        {
            return "Nazvanie PO: " + Name + " Stoimost: " + Value + " Trebovaniya: " + Requirements;
        }

        public TextProcessor(string Poname, int Povalue, string Porequirements, int Wspeed) : base(Poname, Povalue, Porequirements)
        {
            WriteSpeed = Wspeed;
        }

        public new void Lower(int a)
        {
            Value = Value - 2 * a;
            Console.WriteLine("New Value of " + Name + " " + "= " + Value);
        }

        public new void Vivod()
        {
            Console.WriteLine("Nazvanie PO: " + Name + " Stoimost: " + Value + " Trebovaniya: " + Requirements + " Skorost pechati: " + WriteSpeed);
        }

        public override void SAS()
        {
            base.SAS();
            Console.WriteLine("SESSSSSSS");
        }

    }

    partial class Word : TextProcessor
    {
        int Version { get; set; }

        public struct WordInfo
        {
            public string Name;
            public byte Version;

            public WordInfo(string Name, byte Version)
            {
                this.Name = Name;
                this.Version = Version;
            }
        }
    }

    class Virus : PO, IValueOptions
    {
        int Vdamage { get; set; }

        public Virus(string Poname, int Povalue, string Porequirements, int vdamage) : base(Poname, Povalue, Porequirements)
        {
            Vdamage = vdamage;
        }

        public override string ToString()
        {
            return "Nazvanie PO: " + Name + " Stoimost: " + Value + " Trebovaniya: " + Requirements;
        }

        public new void Vivod()
        {
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("Virus:");
            Console.WriteLine("Nazvanie PO: " + Name);
            Console.WriteLine("Stoimost: " + Value);
            Console.WriteLine("Trebovaniya: " + Requirements);
            Console.WriteLine("Uron virusa(zarashennie mashini): " + Vdamage);
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine();
        }
    }

    class Conficker : Virus
    {

        string sas = "ses";

        public Conficker(string Poname, int Povalue, string Porequirements, int vdamage) : base(Poname, Povalue, Porequirements, vdamage)
        {

        }

    }
    class Game : PO
    {
        string _GameType;

        public string GameType
        {
            get { return _GameType; }
            set { _GameType = value; }
        }

        public Game(string Poname, int Povalue, string Porequirements, string Type) : base(Poname, Povalue, Porequirements)
        {
            GameType = Type;
        }

    }
    class Saper : Game
    {
        string Slojnost { get; set; }

        public Saper(string Poname, int Povalue, string Porequirements, string Type, string Slojnost1) : base(Poname, Povalue, Porequirements, Type)
        {
            Slojnost = Slojnost1;
        }
    }
    sealed class Developer
    {
        private string _Devname;

        public string Devname
        {
            get { return _Devname; }
            set { _Devname = value; }
        }
        public Developer(string a)
        {
            Devname = a;
        }

        public void GoWork(PO a, Naboroperaciy b)
        {
            Console.WriteLine(Devname + " Rabotaet nad " + a.Name + " Dobovlyaet tuda " + b.Nabor);
        }
    }
    class Naboroperaciy
    {
        private string _Nabor;
        public string Nabor
        {
            get { return _Nabor; }
            set { _Nabor = value; }
        }

        public Naboroperaciy(string a)
        {
            Nabor = a;
        }
    }
}
