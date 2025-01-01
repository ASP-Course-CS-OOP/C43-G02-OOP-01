using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    #region Part 13 Access Modifiers (private protected, protected, internal protected) EX02

    #region Accessibility Scope [Without Inheritence Scope] => just Make object From "TypeAEX02" Class and Try To Access it's Fields.
    internal class TypeBEX021
    {
        public void Test()
        {
            TypeAEX02 objAEX02 = new TypeAEX02();
            //objAEX02.H = 5;////[Not Valid] => Can't Access The Field "X" Because it's "private" Accessibility Scope.
            //objA.X = 10;//[Not Valid] => Can't Access The Field "X" Because it's "private" Accessibility Scope.
            //objA.Y = 20;//[Valid] => Could Access The Field "Y" Because it's "private" Accessibility Scope.
            objAEX02.Z = 30;//[Valid] => Could Access The Field "Z" Because it's "internal" Accessibility Scope and i'm in Common Project [Same Project of "TypeAEX02" class]. 
        }
    }
    #endregion

    #region Inheritence Scope [With Inheritence Scope] => Make Inheritence [TypeBEX022 : TypeAEX02] and Try To Access "TypeAEX02" Fields Throw Function .
    internal class TypeBEX022 : TypeAEX02
    {
        public void Test()
        {
            //H = 5;//[Not Valid] => Can't Access The Field "H" Because it's "private".
            X = 10;//[Valid] => Could Access The Field "X" Because it's "private protected" Mean That it Can Inherited To Child Classes like "TypeBEX022" That Inherit From Base Class "TypeAEX02" but Inherite only in child classes that in same project "Common", "X "Inherited As "private" Field.
            Y = 20;//[Valid] => Could Access The Field "Y" Because it's "protected" Mean That it Can Inherited To Child Classes like "TypeBEX022" That Inherit From Base Class "TypeAEX02" but Inherited in child classes that in same project "Common" and another projects "Common" , "Y "Inherited As "private" Field.
            Z = 30;//[Valid] => Could Access The Field "Z" Because it's "internal protected" Mean That it Can Inherited To Child Classes like "TypeBEX022" That Inherit From Base Class "TypeAEX02" but Inherited in child classes that in same project "Common" As "internal" ,and another projects "Common" As "private".
        }
    }
            #endregion

        #endregion
}
