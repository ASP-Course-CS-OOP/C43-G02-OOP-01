using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    [Flags]
    internal enum WeekDays:byte
    {
        Monday = 1,Tuesday = 2,Wednesday = 4,Thursday = 8,Friday = 16,Saturday = 32,Sunday = 64
    }
}
