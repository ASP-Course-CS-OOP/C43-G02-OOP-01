using System;
using System.Security.AccessControl;
using Common;//I make It "Common" Global Using In Properties OF "Demo" Project => So I Can Use Items Of This Name Space Inside Any File OF "Demo" Project Without Writing "Using Common". 
using static Common.IExample;
namespace Demo
{
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
            TypeR objR = new TypeR();//You Allowed To Make object From This Class "TypeR" because It's public in "Common" Project.
            //objR.X = 10;//Error, Because The Field (X) Inside The Class (TypeR) is Private. 
            //objR.Y = 10;//Error, Because The Field (Y) Inside The Class (TypeR) is internal, Mean That Accessed Only Inside The Project ( Common ).  
            objR.Z = 10;//Can Access Field (Z) Because it's public, Mean That it Accessed EveryWhere Inside & Outside The Project (Common).
            Console.WriteLine(objR.Z);//10

            objR.AccessX();//0 => Because The Default Value Of int Field is (0).
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

        }
    }
}
