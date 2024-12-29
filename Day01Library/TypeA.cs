using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
    #region Part 03 Namespace Members (User-defined Types)

#region What You Can Write Inside Namespace ?
    /*
         * 1- Class
         * 2- Struct
         * 3- Interface
         * 4- Enum
         * 5- Delegate
         * 6- Record [C# 9.0 Feature]
         * 7- Another Namespaces [Nested Namespaces]
     */
#endregion

#endregion
{
    #region Part 04 Namespace Members - Class, Struct

    #region Class
    internal class TypeA // Internal => Mean That You Can Use This Class Inside The (Same Assembly) (Same Project) Only.
                         // You Can Make Instance From It Inside The Same Assembly (Same Project) Only, Like In TypeB Class.
                         // You Can't Make Institiation From It In Another Project (Assembly).
    {
        public TypeA()//Default Constructor. 
        {
            //TypeC typeCobj = new TypeC();// Error ,Because TypeC Class Access Modifier Is [File], So We Can Use It Inside The Same File Only, Not In Another Place Even Same Project like [TypeA.cs] File Which In The Same Project [Demo].
        }

        #region What You Can Write Inside Class ?
        /*
             * 1- Fields [Attributes - Member Variables]
             * 2- Properties [Full - Automatic]
             * 3- Indexers
             * 4- Methods [Normal - Virtual - Abstract]
             * 5- Operators
             * 6- Constructors [Parametrized - ParameterLess(Default)]
             * 7- Destructor
             * 8- Events
             * 9- Static Members [Fields - Properties - Methods - Constructor]
             * 10 Nested Types [Classes - Structs - Interfaces - Enums - etc..]
         */
        #endregion

        #region Allowed Access Modifiers Inside Class ?
        //All Access Modifiers Are Allowed Inside Class Except [File].
        /*
             * 1- Private [Default]
             * 2- Private Protected
             * 3- Protected
             * 4- Internal
             * 5- Internal Protected
             * 6- Public
         */
        #endregion

    }
    #endregion

    #endregion

    #region  Part 04 Namespace Members - Class, Struct

    #region Struct
    internal struct TypeStruct
    {

        #region What You Can Write Inside Class ?
        /*
             * 1- Fields [Attributes - Member Variables]
             * 2- Properties [Full - Automatic]
             * 3- Indexers
             * 4- Methods [Normal only] => Can't Write Virtual - Abstract Methods
             * 5- Operators
             * 6- Constructors [ParameterLess(Default) only] => Can't Write Parametrized Constructor.
             * 7- Events
             * 8- Static Members [Fields - Properties - Methods - Constructor]
             * 9 Nested Types [Classes - Structs - Interfaces - Enums - etc..]
         */
        #endregion

        #region Allowed Access Modifiers Inside Struct
        //All Access Modifiers Are Allowed Inside Struct Except Inheritence Access Modifiers [private protectes - protected - internal protected]
        //The Allowed Access Modifiers Inside Struct Are [Private [Default] - Internal - Public]
        //There Is Because Struct Is Value Type, Not Reference Type Like Class, So It Can't Inherit From Another Struct Or Class.
        #endregion

    }
    #endregion

    #endregion

}
