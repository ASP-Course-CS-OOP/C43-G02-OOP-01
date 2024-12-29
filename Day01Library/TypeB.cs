using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB // Internal[Default] => Mean That You Can Use This Class Inside The (Same Assembly) (Same Project) Only.
    {
        public TypeB() //Constructor => Special Method That Called When You Create Object From This Class, Not Has Return Type, it's Name Like ClassName.
        {
            TypeA typeAobj = new TypeA();//Because TypeA Class Is Internal, So We Can Use It Inside The Same Assembly (Same Project).

            TypeC typeCobj = new TypeC();//Because TypeC Class Access Modifier Is File, So We Can Use It Inside The Same File Only, Not In Another Place Even Same Project.
        }
    }

    file class TypeC // File => Mean That You Can Use This Class Inside The (Same File) Only.
    {
    }
}
