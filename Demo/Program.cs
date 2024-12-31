using System;
using System.Security.AccessControl;
using Common;//I make It "Common" Global Using In Properties OF "Demo" Project => So I Can Use Items Of This Name Space Inside Any File OF "Demo" Project Without Writing "Using Common". 
using static Common.IExample;
namespace Demo
{
    internal class Program
    {
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

        }
    }
}
