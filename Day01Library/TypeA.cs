using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeA // Internal => Mean That You Can Use This Class Inside The (Same Assembly) (Same Project) Only.
                         // You Can Make Instance From It Inside The Same Assembly (Same Project) Only, Like In TypeB Class.
                         // You Can't Make Institiation From It In Another Project (Assembly).
    {
        public TypeA()
        {
            //TypeC typeCobj = new TypeC();// Error ,Because TypeC Class Access Modifier Is [File], So We Can Use It Inside The Same File Only, Not In Another Place Even Same Project like [TypeA.cs] File Which In The Same Project [Demo].
        }

    }
}
