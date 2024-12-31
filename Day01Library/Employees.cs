using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    #region Part 12 Access Modifiers (private protected, protected, internal protected) EX01

    #region violate Encapsulation Pillar [Make Fields[Data] public]  [public]
    abstract class EmployeeBase01 // Abstract To Prevent Make Institiation/object From It, Because It Not Real Found In The System, I Just Have (Full & Part) Time Employees, Just Make It To Be Container Of Common Fields-Properties-Behaviours of Another Classes
    {
        public int Id;
        public string? Name;
        public int Age;
    }

    class FullTimeEmployee01 : EmployeeBase01//FullTimeEmployee Is A Employee [inheritence].
    {
        public int Id; //Compiler Tell Me That You Don't Need To Write Those Fields Because You Already Inherit Them From EmployeeBase01 Class.
        public string? Name;
        public int Age;
        public decimal salary;
    }

    class PartTimeEmployee01 : EmployeeBase01//PartTimeEmployee Is A Employee [inheritence].
    {
        public int Id;
        public string? Name;
        public int Age;
        public decimal HourRate;
    }
    #endregion

    #region Apply Encapsulation [private Data] & Violate Inheritence [Repeat Data in each class] [private].
    abstract class EmployeeBase02 
    {
        private int Id;
        private string? Name;
        private int Age;
    }

    class FullTimeEmployee02 : EmployeeBase02
    {
        private int Id; // This Id Differ From Id Of EmployeeBase02 Class, Because The Field "Id" in the EmployeeBase Class Is Private Mean That You Can't Access It [Only In EmployeeBase Region].[So Where The Inheritence ? [I Repeat Same Code[Fields] in each class]]
        private string? Name;
        private int Age;
        private decimal salary;
    }

    class PartTimeEmployee02 : EmployeeBase02
    {
        private int Id;
        private string? Name;
        private int Age;
        private decimal HourRate;
    }
    #endregion

    #region Apply Encapsulation [private Data] & Inheritence But Child Class Can Only Deal With BaseClass Data Inside Same Assemply/Project Only [private protected Fields] [private protected].
    //private protected =>
    //private => Mean That This Field Is Private For it's Class Only [Accessibility Level]
    //protected => Mean That This Field can inherit/pass to class that inherit from EmployeeBaseClass and this field will be private in child class.
    //But Child Class Can Access Those [private protected] Fields only if the child class in the same project [Common].
    public abstract class EmployeeBase03
    {
        private protected int Id;// Restricted access [ Accessed in inherited Classes in the same assemply/project only ]
        private protected string? Name;
        private protected int Age;
    }

    class FullTimeEmployee03 : EmployeeBase03
    {
        //private int Id; 
        //private string? Name;
        //private int Age;
        private decimal salary;
    }

    public class PartTimeEmployee03 : EmployeeBase03
    {
        //private int Id;
        //private string? Name;
        //private int Age;
        private decimal HourRate;

        public void DisplayAge()
        {
            Console.WriteLine(Age); // Accessible here [Same Project Of BaseClass Project [Common] ] & Can't Make This Inside Classes inherit from EmployeeBase04 in the different project.
        }
    }
    #endregion

    #region Apply Encapsulation [private Data] & Inheritence, But Child Class Can Deal With BaseClass Data Inside Same Assemply/Project And Outside It [Protected Fields] [protected].
    //private protected =>
    //private => Mean That This Field Is Private For it's Class Only [Accessibility Level]
    //protected => Mean That This Field can inherit/pass to class that inherit from EmployeeBaseClass and this field will be private in child class.
    //But Child Class Can Access Those [private protected] Fields only if the child class in the same project [Common].
    public abstract class EmployeeBase04
    {
        protected int Id;//Accessible in derived classes [Regardless in same assemply/project or not].
        protected string? Name;
        protected int Age;

        internal void DisplayID01()// This Method Inherited Only By The Classes In The Same Assemply/Project (Common) and inherited as "internal" and other child classes that inherit from this "EmployeeBase04" class in other projects can't inherit thi method.
        {
            Console.WriteLine(Id);
        }
        
        internal protected void DisplayID02()// This Method Inherited By The Classes In The Same Assemply/Project (Common) or in another projects [inherited as "private" method if the childClass in another project and "internal" method if the childClass in same project].
        {
            Console.WriteLine(Id);
        }
    }

    class FullTimeEmployee04 : EmployeeBase04
    {
        //private int Id;
        //private string? Name;
        //private int Age;
        private decimal salary;
    }

    public class PartTimeEmployee04 : EmployeeBase04
    {
        //private int Id
        //private string? Name;
        //private int Age;
        private decimal HourRate;

        public void DisplayAge()
        {
            Console.WriteLine(Age); // Accessible here [Same Project Of BaseClass Project [Common] ] & Can Make This Also Inside Classes inherit from EmployeeBase04 in the different project.
        }
    }
    #endregion


    #endregion
}
