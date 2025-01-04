using System.Transactions;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

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


            #region Part02

            #region Q1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            #region Using Loop, Without [Flags] Attribute.

            //for (int i = 0; i < 7; i++)
            //{
            //    Console.Write((WeekDays)i + " ");
            //}

            #endregion

            #region Using [Flags] Attribute

            //WeekDays02 AllDays = (WeekDays02)127;
            //Console.WriteLine(AllDays); 

            #endregion

            #endregion

            #region Q2.Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //bool isParsed = true;
            //Console.Write("Enter The Season Name: ");
            //isParsed = Enum.TryParse<Season02>(Console.ReadLine(), true, out Season02 result);
            //if (isParsed)
            //{
            //    switch (result)
            //    {
            //        case Season02.Spring:
            //            Console.WriteLine("Spring => March To May.");
            //            break;
            //        case Season02.Summer:
            //            Console.WriteLine("Summer => June  To August.");
            //            break;
            //        case Season02.Autumn:
            //            Console.WriteLine("Autumn => September To November.");
            //            break;
            //        case Season02.Winter:
            //            Console.WriteLine("Winter => December To February.");
            //            break;
            //    }
            //}
            //else
            //    Console.WriteLine("Wrong Season Name!");

            #endregion

            #region Q3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permission02 p01 = (Permission02)3;//Read, Write

            #region Add Delete Permission

            //Add Delete Permission
            p01 = p01 | Permission02.Delete;//3[0011] | 4[0100] = 0111[7] => Read, Write, Delete
            Console.WriteLine(p01);

            #endregion

            #region Remove Delete Permission

            //p01 = p01 & ~(Permission02.Delete);//7[0111] & ~4[0100] = 0111 & 1011 = 0011 = 3 => Read, Write
            //Console.WriteLine(p01);//Read, Write

            #endregion

            #region Check If Read Permission Exist

            //if((p01 & Permission02.Read) == Permission02.Read)//3[0011] & 1[0001] = [0001] => Read
            //    Console.WriteLine("You Have Read Permission.");
            //else
            //    Console.WriteLine("You Don't Have Read Permission!");

            #endregion

            #endregion

            #endregion
        }
    }
}
