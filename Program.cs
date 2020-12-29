using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LabRab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();
            IntelligentCreature Prime = new Transformer("Prime", "1974", "3000");
            IntelligentCreature Bumblebee = new Transformer("Bumblebee", "2002", "1800");
            IntelligentCreature Cliffjumper = new Transformer("Cliffjumper", "1990", "2000");
            IntelligentCreature Wheeljack = new Transformer("Wheeljack", "1988", "2100");
            IntelligentCreature Prowl = new Transformer("Prowl", "1955", "2300");
            IntelligentCreature Roman_Zayats = new Human("Roman_Zayats", "2002", "200");
            IntelligentCreature Valentin_Ermakovich = new Human("Valentin_Ermakovich", "2002", "250");
            IntelligentCreature Vlad_Simakovich = new Human("Vlad_Simakovich", "2002", "300");
            IntelligentCreature Max_Akulevich = new Human("Max_Akulevich", "2001", "280");
            IntelligentCreature Best_Warrior = new Human("Best_Warrior", "1988", "3000");
            army.add(Prime);
            army.add(Bumblebee);
            army.add(Cliffjumper);
            army.add(Wheeljack);
            army.add(Prowl);
            army.add(Roman_Zayats);
            army.add(Valentin_Ermakovich);
            army.add(Vlad_Simakovich);
            army.add(Max_Akulevich);
            army.add(Best_Warrior);

            Controller.GetWarriorByYear(army, "2002");
            Console.WriteLine();
            Controller.PrintWarriors(army, "3000");
            Console.WriteLine();
            Controller.PrintCount(army);

            int[] arr = new int[2];

            try
            {
                arr[3] = 5;

                try
                {
                    arr[3] = 10;
                }
                catch (PersonException ex)
                {
                    Console.WriteLine($"ошибка вида {ex.Message}");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("ошибка вида IndexOutOfRangeException");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("ошибка вида DivideByZeroException");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ошибка вида {ex.Message}");
                }
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ошибка вида IndexOutOfRangeException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ошибка вида DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            try
            {
                Person p = new Person { Name = "Name", Age = 17 };
            }
            catch (PersonException ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ошибка вида IndexOutOfRangeException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ошибка вида DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            try
            {
                zero p = new zero { Val = 0 };
            }
            catch (PersonDivideByZeroException pd)
            {
                Console.WriteLine($"ошибка вида {pd.Message}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ошибка вида IndexOutOfRangeException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ошибка вида DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            try
            {
                massive p = new massive { Val = 23 };
            }
            catch (PersonArgumentOutOfRangeException p)
            {
                Console.WriteLine($"ошибка вида {p.Message}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ошибка вида IndexOutOfRangeException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ошибка вида DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }
            int a = 7;

            int[] aa = null;
            Debug.Assert(aa != null, "Values array cannot be null");

            try
            {
                a = a / 0;
            }
            catch (PersonArgumentOutOfRangeException p)
            {
                Console.WriteLine($"ошибка вида {p.Message}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("ошибка вида IndexOutOfRangeException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ошибка вида DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ошибка вида {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }



            Console.ReadLine();
        }
    }
    class PersonException : ArgumentException
    {
        public int Value { get; }
        public PersonException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class PersonDivideByZeroException : DivideByZeroException
    {
        public int Value { get; }
        public PersonDivideByZeroException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class PersonArgumentOutOfRangeException : ArgumentOutOfRangeException
    {
        public int Value { get; }
        public PersonArgumentOutOfRangeException(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
    class Person
    {
        public string Name { get; set; }
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                    throw new PersonException("Лицам до 18 регистрация запрещена", value);
                else
                    age = value;
            }
        }
    }
    class zero
    {
        private int val;
        public int Val
        {
            get { return val; }
            set
            {
                if (value == 0)
                    throw new PersonException("попытка поделить ноль на ноль", value);
                else
                    val = value;
            }
        }
        public void sum()
        {
            Console.WriteLine("деления числа на себя " + val / val);
        }
    }
    class massive
    {
        private int val;
        public int Val
        {
            get { return val; }
            set
            {
                if (value > 40 || value < 24)
                    throw new PersonArgumentOutOfRangeException("выход за границы допустимых значений", value);
                else
                    val = value;
            }
        }
        public void sum()
        {
            Console.WriteLine("имеет право на пенсию, стаж работы " + val);
        }
    }
    static class Controller
    {
        public static void GetWarriorByYear(Army a, string year)
        {
            foreach (IntelligentCreature i in a.army)
            {
                if (year == i.year)
                {
                    Console.WriteLine(i.name);
                }
            }
        }
        public static void PrintWarriors(Army a, string power)
        {
            foreach (IntelligentCreature i in a.army)
            {
                if (power == i.power)
                {
                    Console.WriteLine(i.name);
                }
            }
        }
        public static void PrintCount(Army a)
        {
            int i = 0;
            foreach (IntelligentCreature e in a.army)
            {
                i++;
            }
            Console.WriteLine(i);
        }
    }
    public class Army
    {
        public List<IntelligentCreature> army = new List<IntelligentCreature> { };
        public void add(IntelligentCreature name)
        {
            army.Add(name);
        }
        public void delete(IntelligentCreature name)
        {
            int number = 0;
            foreach (IntelligentCreature i in army)
            {
                if (i == name)
                {
                    break;
                }
                number++;
            }
            army.RemoveAt(number);
        }
        public void display()
        {
            foreach (IntelligentCreature i in army)
            {
                Console.WriteLine(i.name);
            }
        }
    }

    public abstract partial class IntelligentCreature : Army
    {
        public abstract string name { get; set; }
        public abstract string year { get; set; }
        public abstract string power { get; set; }
    }
    class Human : IntelligentCreature
    {
        public override string power { get; set; }
        public override string name { get; set; }
        public override string year { get; set; }
        public Human(string Name, string Year, string Power)
        {
            name = Name;
            year = Year;
            power = Power;
        }

    }
    class Transformer : IntelligentCreature
    {
        public override string power { get; set; }
        public override string name { get; set; }
        public override string year { get; set; }
        public Transformer(string Name, string Year, string Power)
        {
            name = Name;
            year = Year;
            power = Power;
        }


        enum Soliders
        {
            Prime = 1,
            Bumblebe = 3,
            Cliffjumper,
            Wheeljack,
            Prowl,
            Roman_Zayats,
            Valentin_Ermakovich,
            Vlad_Simakovich,
            Max_Akulevich,
            Best_Warrior
        }
        struct Solider
        {
            public string rank;
            public int power;
        }
    }
}
