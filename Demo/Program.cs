namespace Demo
{

    #region Part 15 Enum
    public enum Gender
    {
        Male = 1, Female = 2
    }
    public enum Grade : byte//I Know Grade Values Of Any Faculty, So I Can Represent Them In DataType(enum)=> "Grade".
    {
        A, B, C, D, F
    }
    public enum RouteBranch : byte
    {
        Dokki, Maadi, BNS, Alex, SmartVillage//-> Labels That Represent Values of Type byte
                                             //        0     1    2   3      4          -> Values Of Type byte
    }
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int salary { get; set; }
        public Gender gender { get; set; }//I Know Gender Values [Male,Female] no else, So Restrict Values of Gender In Enum "Gender"
        public Grade grade { get; set; }
        public RouteBranch branch { get; set; }
    }
    #endregion

    #region Part 17 Enum -  Permissions Example

    #region Ex01 - Before using [Flags] Attribute

    enum Permission01 : byte
    {
        Read = 1, Write = 2, Delete = 4, Update = 8
    }

    #endregion

    #region Ex01 - Before using [Flags] Attribute
    [Flags]
    enum Permission02 : byte
    {
        Read = 1, Write = 2, Delete = 4, Update = 8, Test = 16
    }

    #endregion

    #endregion

    internal class Program :/*EmployeeBase03,*//*EmployeeBase04,*/TypeAEX02
    {

        #region part 12 [private protected]
        public void DisplayAge03()
        {
            //Console.WriteLine(Age);//[Not Valid] => Can't Access The Field "Age" Because it's "private protected" mean that i can access it only in classes inherit from EmployeeBase03 && in the same project(Common) and i now in (Demo) Project. 
        }
        #endregion

        #region part 12 [protected]
        public void DisplayAge04()
        {
            Console.WriteLine(/*Age*/);//[Valid] => Could Access The Field "Age" Because it's "protected" mean that i can access it in classes inherit from EmployeeBase03 Regardless in same assemply/project or not and i in different project (Demo).
        }
        #endregion

        #region Part 13 Access Modifiers (private protected, protected, internal protected) EX02 [In Another Project [Demo] ].
        #region Inheritence Scope
        public void DisplayAge05()
        {
            //H = 0;//[Error], Because The Field "H" Inside The Class "TypeAEX02" is "Private", So You Can't Access It From Another Class Even If This Class Inherit From "TypeAEX02" Class.
            //X = 5;//[Error], Because The Field "X" Inside The Class "TypeAEX02" is "private protected", So You Can't Access It From Another Class Inherit From "TypeAEX02" Class In Another Project, You Only Can Access It Throw Class Inherit From "TypeAEX02" But In Same Project Of "TypeAEX02" Class Which Is "Common project".
            Y = 10;//[Valid], Because The Field "Y" Inside The Class "TypeAEX02" is "protected", So You Can Access It From Another Class Inherit From "TypeAEX02" Class In Another Project As "private" field, And You Can Access It Throw Class Inherit From "TypeAEX02" In Same Project Of "TypeAEX02" Class Which Is "Common project" As "Private" field.
            Z = 15;//[Valid], Because The Field "Z" Inside The Class "TypeAEX02" is "internal protected", So You Can Access It From Another Class Inherit From "TypeAEX02" Class In Another Project As "private" field, And You Can Access It Throw Class Inherit From "TypeAEX02" In Same Project Of "TypeAEX02" Class Which Is "Common project" As "internal" field.
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            #region Part 01 What Is Class Library
            /*
                 * It's Just Library That We Write C# Code Inside It
                 * To use This code In Many Projects/Apps Without Rewrite This Code Again In Every Project,
                 * Just Import This Library In The Project That You Nedd To Use Class Library Inside It.
             */
            #endregion

            #region Part 02 What are Access Modifiers
            //Specify The Accecibility Scope OF Items Like Classes,Structs,Enums,Interfaces,Methods,Properties,Fields,Constructors,.....
            /*
                 * 1- Private 
                 * 2- Private Protected [C# 7.3 Feature] [Has Inheritence Scope]
                 * 3- Protected                          [Has Inheritence Scope]
                 * 4- Internal
                 * 5- Internal Protected                 [Has Inheritence Scope]
                 * 6- Public
                 * 7- File
             */
            #endregion

            #region Part 03 Namespace Members (User-defined Types)
            //TypeA typeAobj;//Not Recognized, Because The TypeA Class Is Internal , Mean That You Can't Make Institiation From It In Another Project (Assembly)
            //TypeC typeCobj = new TypeC();//Error, Because TypeC Class Access Modifier Is [File], So We Can Use It Inside The Same File Only [TypeB.cs], Not In Another Place Like Another Project [Demo]. 
            #endregion

            #region Part 07 Namespace Members - Delegate
            //func fun01 = delegate (int num1, int num2)
            //    {
            //        return $"Summ => {num1 + num2}";
            //    }; 
            //Console.WriteLine(fun01(5, 10));
            #endregion

            #region Part 10 Access Modifiers for Namespace Members (file, internal, public)
            //Namespace Members => [struct - enum - class - interface - delegate - record - nested namespaces]
            //Allowed Access Modifiers Inside Namespace ?
            // 1- file        2- internal[Default]     3- public

            #region file
            //Access Namespace Member (Make object From It) Inside Current File Only.
            #endregion

            #region internal [Default]
            //You Only Can Access This Member (Make object From It) inside Current Project Only, Even If You Import This Project In Another Project.
            #endregion

            #region public
            //Access This Member In Any Place Regardless Inside Or Outside The Project Which Member Created In.
            #endregion

            #endregion

            #region Part 11 Access Modifiers (private, internal, public) Inside Members Of Namespace
            //TypeR objR = new TypeR();//You Allowed To Make object From This Class "TypeR" because It's public in "Common" Project.
            //objR.X = 10;//Error, Because The Field (X) Inside The Class (TypeR) is Private. 
            //objR.Y = 10;//Error, Because The Field (Y) Inside The Class (TypeR) is internal, Mean That Accessed Only Inside The Project ( Common ).  
            //objR.Z = 10;//Can Access Field (Z) Because it's public, Mean That it Accessed EveryWhere Inside & Outside The Project (Common).
            //Console.WriteLine(objR.Z);//10

            //objR.AccessX();//0 => Because The Default Value Of int Field is (0).
            #endregion

            #region part 12 [internal Method Inside Parent Class And Take object from Child Class That Inherit From Base Class And Try to Access The internal Method inside The Parent Class throw Child class but in different project [Demo]] [Invalid => Method is internal]
            //PartTimeEmployee04 p04 = new PartTimeEmployee04();
            //p04.DisplayID();// DisplayId() Method is internal in BaseClass (EmployeeBase04) So you Can Access It Only Throw Object From Class Inherit From EmployeeBase04 But In Same Assemply/Project (Common) Only.
            #endregion

            #region Part 13 Access Modifiers (private protected, protected, internal protected) EX02 [ In Another Project [Demo] ]

            #region Accessibility Scope [Without Inheritence Scope]
            TypeAEX02 objAEX021 = new TypeAEX02();
            //objAEX02.X = 10;//[Not Valid] => Can't Access The Field "X" Because it's "private" Accessibility Scope.
            //objAEX02.Y = 20;//[Not Valid] => Can't Access The Field "Y" Because it's "private" Accessibility Scope.
            //objAEX02.Z = 30;//[Not Valid] => can't Access The Field "Z" Because it's "internal" Accessibility Scope and i'm in "Demo" Project [Not int the same Project of "TypeAEX02" class => "Common"]. 
            #endregion

            #region Summary
            //Accessibility Scope => Mean That Make object From Class Like "TypeA" Inside The Project Of "TypeA" [Common] Or Another Project [Demo] And Check If This object Could Access Fields Of The Class "TypeA". [ private - internal - public]
            //Inheritance Scope => Mean That Make Child Class And Check If This Child Class Inherit The Fields Of Parent Class Or Not [ private protected - protected - internal protected ].

            #region private

            #region Accessibility Scope
            //private Field Accessed Only Inside The Class Itself.[Encapsulation].
            #endregion

            #region Inheritence Scope
            //Private Field Not Inherited.
            #endregion

            #endregion

            #region internal

            #region Accessibility Scope
            //internal Field Accessed Through object From Class Inside The Same Project Only (Institiation/object must taked in place inside project of the class that this object taked from it)
            #endregion

            #region Inheritence Scope
            //internal field inherited to class that inherit from this base class but in same assembly/project only.
            #endregion

            #endregion

            #region public

            #region Accessibility Scope
            //public field accessed everywhere, throw object from this class regardless this institiation/object made in same project or not. 
            #endregion

            #region Inheritence Scope
            //public field inherited to child classes that inherit this base class, Regardless those child classes are in same project of base class or not.
            //This Field Inherited As "public" Field.
            #endregion

            #endregion

            #region private protected

            #region Accessibility Scope
            //private protected field accessed only inside the class itself. [encapsulation]
            #endregion

            #region Inheritence Scope
            //private protected field inherited to child classes that inherit this base class , but in case those child classes in same project of base class only.
            //this field inherited as "private" field.
            #endregion

            #endregion

            #region protected

            #region Accessibility Scope
            //protected field accessed only inside class [Encapsulation], it has inheritence scope only, mean that if you make object from this class that contain this protected field, this object can't access this protected field.
            //same as private field in accessibility scope, but protected field has inheritence scope.
            #endregion

            #region Inheritence Scope
            //protected field inherited to child classes that inherit from this base class, regardless those child classes are in same project of base class or not.
            //this protected field inherited as "private" field inside child class that inherit base class in same project & inherited as "private" field inside child class that inherit base class in another project.
            #endregion

            #endregion

            #region internal protected

            #region Accessibility Scope
            //internal protected field accessed throw object from this class that this field in it, but in case this institiation/object happen in same project of this class only.
            #endregion

            #region Inheritence Scope
            //internal protected field inherited to child classes that inherit from this base class Regardless those child classes inside the smae project of base class or not 
            //this internal protected field inherited as "internal" field inside child class that inherit base class in same project & inherited as "private" field inside child class that inherit base class in another project.
            #endregion

            #endregion

            #endregion

            #endregion

            #region Part 15 Enum - Namespace Member - User Define Type
            //It's Just DataType That Represent Group Of Values That I Know Them, Like ( Gender=>[Male,Female] ),
            //So I Need To Represent Those Values Into DataType[enum],
            //By Default enum is of Type (int), Mean That When Take Variable Of Type Enum, It Will Take 4 bytes In Memory.
            //enum Is Rerepresentation Of Numeric Types (By Default int) , Represented In Labels.

            #region Ex01
            //Person p01 = new Person();
            //p01.Id = 1000;
            //p01.Name = "Eslam";
            //p01.salary = 10_000;
            //p01.gender = Gender.Male;
            //p01.grade = Grade.A;
            //p01.branch = RouteBranch.Dokki;

            //Console.WriteLine($"Id => {p01.Id}");//1000
            //Console.WriteLine($"Name => {p01.Name}");//Eslam
            //Console.WriteLine($"salary => {p01.salary}");//10000
            //Console.WriteLine($"Gender => {p01.gender}");//Male 
            //Console.WriteLine($"Gender => {p01.grade}");//A 
            //Console.WriteLine($"Branch => {p01.branch}");//A 
            #endregion

            #region Ex02
            //Gender gender;//Variable "gender" of Type ValueType(enum) => "Gender", Take 4 bytes in memory
            //gender = Gender.Female;

            //Console.WriteLine(gender);//Female
            #endregion

            #region Ex03
            //Grade MyGrade = Grade.D;

            //if(MyGrade == Grade.A)
            //    Console.WriteLine("Excellent");
            //Console.WriteLine("Poor");
            #endregion

            #region Ex04
            //Grade g01 = 3;//Error, Because You Need To Tell Compiler That See This Value As (Grade) Or As (Label)
            //Grade g01 = (Grade)3;
            //Console.WriteLine(g01);//D

            //Grade g02 = (Grade)10;//There Is No Representation (Label) For Value (10) In The enum (Grade), So It Will Print Value itself (10).
            //Console.WriteLine(g02);//10

            //Grade g03 = (Grade)1532362561515;//Error, Because The enum(Grade) is of numeric type(int) which represent numeric values from ( 0 - 2,147,483,647 )
            ////And (1532362561515) is long value that Exceed This Numeric Value(2147483647), So Use enum of type long represent long values like (1532362561515).

            //Grade g04 = (Grade)255;//There Is No Representation (Label) For Value (255) In The enum (Grade) of type byte, So It Will Print Value itself (255).
            //Console.WriteLine(g04);//255

            //Grade g05 = (Grade)256;//The enum(Grade) of type byte That Represent Values from 0 - 255 in Labels, Can't Represent 256 As byte Value in Label.

            #endregion

            #region Ex05
            //RouteBranch b01 = RouteBranch.Dokki;
            //Console.WriteLine(b01);//Dokki
            #endregion

            #region enum Summary
            //enum is Rerepresentation of numeric values/Types Like (int) in Labels
            //Always Make enum to be representation of byte values/types as long as i don't need more than 256 value/label 
            //So save memory, because when make variable of type enum represented type values, it will take just 1 byte from memory. 
            //every label represent byte value, compiler give every label value of type byte start from 0 - 255.
            #endregion

            #endregion

            #region Part 16 Enum - Casting - Casting From String To enum Using Methods Of (Enum) Class => [ Enum.Parse() - Enum.TryParse() ].

            #region Parse() -> Enum.Parse(typeof(enum),string) - Enum.Parse<enum>(string) .
            #region Enum.Parse(typeof(enum),string) => Cause Boxing & UnBoxing [Before Generics] - Depends On object instead of Generics which cause Boxing & UnBoxing.
            //string gender = "Male";
            //Enum.Parse(typeof(Gender), gender);//This Method "Parse()" Return object if The String "Male" Match Label In enum "Gender".
            ////In This Case, "Male" is label in "Gender" enum, so "Parse()" Method return the value of this label "Male" which is "0" in enum. 
            ////But Parse() return object, so this value "0" will boxing inside object in heap and Parse() return the address of this object. 

            ////Gender g01 = Enum.Parse(typeof(Gender), gender);//Error, Because (g01) is variable in stack that hold values, and Parse() return object, so must unboxing the object that contain "0" to value cause "UnBoxing".

            //Gender g01 =(Gender) Enum.Parse(typeof(Gender), gender);
            //Console.WriteLine(g01);//Male
            #endregion

            #region Enum.Parse<EnumType>(String) => Not Cause Boxing & UnBoxing [With Generics].

            #region Casting From String To enum Done => Not Throw exception.
            //Gender g01 = Enum.Parse<Gender>("Male");//Cast String "Male" To enum "Gender", But Not Cause [Boxing & UnBoxing].
            //Console.WriteLine(g01);//Male 
            #endregion

            #region Casting from String To enum Fail => Throw Exception.

            //Gender g02 = Enum.Parse<Gender>("WrongLabel");
            //Console.WriteLine(g02);//Throw 

            #endregion

            #endregion

            #region Casting from String "male" To enum "Gender" Fail => Throw Exception => Because "male" is not recognized as label in "Gender" enum.

            #region Before Generics Approach => Enum.Parse(typeof(Gender),"male");

            //Gender g03 = (Gender)Enum.Parse(typeof(Gender), "male");
            //Console.WriteLine(g03);//Throw Exception. 

            #endregion

            #region With Generics Approach => Enum.Parse<Gender>("male");

            //Gender g04 = Enum.Parse<Gender>("male");
            //Console.WriteLine(g04);//Throw Exception. 

            #endregion

            #endregion

            #region Casting from String "male" To enum "Gender" Done => Using Parameter Of Ignore Case Sensitivity.

            #region Before Generics Approach => Enum.Parse(typeof(Gender),"male",true);

            //Gender g03 = (Gender)Enum.Parse(typeof(Gender), "male",true);
            //Console.WriteLine(g03);//Male 

            #endregion

            #region With Generics Approach => Enum.Parse<Gender>("male",true);

            //Gender g04 =Enum.Parse<Gender>("male",true);
            //Console.WriteLine(g04);//Male 

            #endregion


            #endregion

            #endregion

            #region TryParse() -> Enum.TryParse(typeof(enum),string,out object?) - Enum.Parse<enum>(string,Gender) 

            #region Enum.TryParse(typeof(enum),string,out object?) => Cause Boxing & UnBoxing [Before Generics] - Depends On object instead of Generics which cause Boxing & UnBoxing.

            #region Ex01 - Cast Done

            //Gender g01;
            //Enum.TryParse(typeof(Gender), "Male", out object? result01 /*Boxing Value(1) of label "Male" in object and return address of this object to reference result01 in stack*/);
            //g01 = (Gender)(result01 ?? -1);//Unboxing -> (Cast Pass) -> So Convert the object that reference (result01)refer to which contain the value of label ("Male" -> 1) to valueType which is of type Gender.
            ////(-1) => Not Represented as label in The Gender Generic, So It's Can Indicate To Fail Casting 
            //Console.WriteLine(g01);//Male 

            #endregion

            #region Ex01 - Cast Fail

            //Gender g02;
            //Enum.TryParse(typeof(Gender), "Male", out object? result02);
            //g02 = (Gender)(result02 ?? -1);//(Cast Fail) -> So the object (result01) contain/Refer to Null, and then we say if object is null put -1 in g02.
            ////(-1) => Not Represented as label in The Gender Generic, So It's Can Indicate To Fail Casting 
            //Console.WriteLine(g02);//-1

            #endregion

            #endregion

            #region Enum.TryParse<enum>(string,out enum) => Not Cause Boxing & UnBoxing [With Generics].

            #region Ex01 - Cast Done

            //Gender g03;
            //Enum.TryParse<Gender>("Male", out Gender result01);
            //g03 = result01;
            ////Casting Done (Convert from "Male" to Gender), result will contain the value of matched label, in this case will contain (1).

            //Console.WriteLine(g03);//Male 

            #endregion

            #region Ex02 - Cast Fail

            //Gender g04;
            //Enum.TryParse<Gender>("NotLabel", out Gender result02);
            //g04 = result02;
            ////Casting Fail (Convert from "NotLabel" to Gender), result will contain The default value of enum valueType -> (0) ,So Note To Not Attach Label In Enum With value (0);

            //Console.WriteLine(g04);//0

            #endregion

            #endregion

            #region Casting from String "male" To enum "Gender" Fail => Throw Exception => Because "male" is not recognized as label in "Gender" enum.

            #region Before Generics Approach => Enum.TryParse("male",Gender);

            //Gender g05;
            //Enum.TryParse(typeof(Gender),"male",out object? result05 );
            //g05 = (Gender)(result05 ?? -1);

            //Console.WriteLine(g05);//-1

            #endregion

            #region With Generics Approach => Enum.TryParse<Gender>("male",out Gender);

            //Gender g06;
            //Enum.TryParse<Gender>("male", out Gender result06);
            //g06 = result06;

            //Console.WriteLine(g04);//0

            #endregion

            #endregion

            #region Casting from String "male" To enum "Gender" Done => Using Parameter Of Ignore Case Sensitivity.

            #region Before Generics Approach => Enum.TryParse(typeof(Gender),"male",true,out object?);

            //Gender g07;
            //Enum.TryParse(typeof(Gender), "male", true, out object? result07);
            //g07 = (Gender)(result07 ?? -1);

            //Console.WriteLine(g07);//Male 

            #endregion

            #region With Generics Approach => Enum.TryParse<Gender>("male",true,out Gender);

            //Gender g08; 
            //Enum.TryParse<Gender>("male", true,out Gender result08);
            //g08 = result08;

            //Console.WriteLine(g08);//Male 

            #endregion


            #endregion

            #endregion

            #endregion

            #region Part 17 Enum -  Permissions Example

            #region Ex01 Without [Flags] 

            //Permission01 MyPermissions01 = (Permission01)3;//I need To Say That I Have (Read,Write) Permissions By Combine The Value Of The Labels (Read = 1, Write = 2).
            ////But The Default Behavior Of Compiler is To Try To Found The Label Thar Represent The Value (3) in Permission enum but not found it, So Return (3).
            //Console.WriteLine(MyPermissions01);//3

            ////So We Need To Add new Behavior For Searching on Matched Value in enum To Combine Allowed LabelValues That match the value, like if (3) Combine (read,write) that are representation for (1,2).
            ////To Add This Behavior, We use [Flags] Attribute.

            #endregion

            #region Ex02 - Using [Flags]

            Permission02 MyPermissions02 = (Permission02)3;
            Console.WriteLine(MyPermissions02);//Read,Write

            Permission02 MyPermissions03 = (Permission02)31;
            Console.WriteLine(MyPermissions03);//Read, Write, Delete, Update, Test

            #endregion

            #endregion

        }
    }
}
