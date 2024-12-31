using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB:/*EmployeeBase03,*/EmployeeBase04// Internal[Default] => Mean That You Can Use This Class Inside The (Same Assembly) (Same Project) Only.
    {
        #region part 12 [private protected]
        public void DisplayAge()
        {
            Console.WriteLine(Age);//[Valid] => Could Access The Field "Age" Because it's "private protected" mean that i can access it only in classes inherit from EmployeeBase03 && in the same project(Common) and i now in (Common) Project. 
        }
        #endregion

        #region part 12 [protected]
        public void DisplayAge04()
        {
            Console.WriteLine(Age);//[Valid] => Could Access The Field "Age" Because it's "protected" mean that i can access it in classes inherit from EmployeeBase03 Regardless in same assemply/project or not and i in Same project (Common).
        }
        #endregion

        public TypeB() //Constructor => Special Method That Called When You Create Object From This Class, Not Has Return Type, it's Name Like ClassName.
        {
            #region Part 02 What are Access Modifiers
            TypeA typeAobj = new TypeA();//Because TypeA Class Is Internal, So We Can Use It Inside The Same Assembly (Same Project).

            TypeC typeCobj = new TypeC();//Because TypeC Class Access Modifier Is File, So We Can Use It Inside The Same File Only, Not In Another Place Even Same Project. 
            #endregion

            #region Part 11 Access Modifiers (private, internal, public) Inside Members Of Namespace
            TypeR objR = new TypeR();
            objR.Y = 10;//Can Access, Because The Field (Y) Inside The Class (TypeR) is internal, Mean That Accessed Only Inside The Project ( Common ), And This Class (TypeB) is in (Common) Project.  
            #endregion
        }
    }

    file class TypeC // File => Mean That You Can Use This Class Inside The (Same File) Only.
    {
    }
}
