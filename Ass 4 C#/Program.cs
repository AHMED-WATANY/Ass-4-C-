using Ass_4_C_;

namespace Ass_4_C_

{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    [Flags]
    enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }


    internal class Program
    {
        static void Main(string[] args)
        {

           



            // PART 2

            #region Q1
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region Q2

            Console.Write("Enter the season name (Spring, Summer, Autumn, Winter): ");
            string seasonInput = Console.ReadLine();

            if (Enum.TryParse(seasonInput, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season entered.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }

            Console.ReadLine();

            #endregion

            #region Q3


            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine("Initial Permissions: " + userPermissions);

            userPermissions |= Permissions.Delete;
            Console.WriteLine("After Adding Delete: " + userPermissions);

            userPermissions &= ~Permissions.Write;
            Console.WriteLine("After Removing Write: " + userPermissions);

            bool hasExecute = (userPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine("Has Execute Permission: " + hasExecute);

            Console.ReadLine();

            #endregion

            #region Q4


            Console.Write("Enter a color name (Red, Green, Blue): ");
            string colorInput = Console.ReadLine();

            if (Enum.TryParse(colorInput, true, out Colors color))
            {
                if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                {
                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{color} is not a primary color.");
                }
            }
            else
            {
                Console.WriteLine("Invalid color entered.");
            }

            Console.ReadLine();





            #endregion


        }
    }

}




















