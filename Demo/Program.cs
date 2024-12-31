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

        }
    }
}
