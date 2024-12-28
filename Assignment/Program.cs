namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //WeekDays DaysOfWeek = (WeekDays)127;
            //Console.WriteLine(DaysOfWeek);
            #endregion

            #region 2.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //bool isParsed = Enum.TryParse<Season>(Console.ReadLine(), true, out Season season);

            //if (isParsed)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Not Recognized Season Name");
            #endregion

            #region 3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permission permission = (Permission)3;
            //Console.WriteLine(permission);//Read Write
            //permission |= Permission.Delete;
            //Console.WriteLine(permission);//Read Write Delete
            //permission &= ~Permission.Delete;
            //Console.WriteLine(permission);//Read Write      

            //if((permission & Permission.Delete) == Permission.Delete) //0011 & 1000  0000
            //    Console.WriteLine("You Have Delete Permission");
            //else
            //    Console.WriteLine("You Don't Have Delete Permission");
            #endregion

            #region 4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //bool isParsed = Enum.TryParse<Colors>(Console.ReadLine(), true, out Colors color);

            //if (isParsed)
            //{
            //    if(color == Colors.Red || color == Colors.Blue || color == Colors.Green)
            //        Console.WriteLine($"{color} is Primary Color");
            //}
            //else
            //    Console.WriteLine("not primary color");
            #endregion
        }
    }
}
