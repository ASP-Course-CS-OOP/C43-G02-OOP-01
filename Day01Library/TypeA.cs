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
             * 9- Static Members [Fields - Properties - Methods - Constructor] And Constants
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
             * 8- Static Members [Fields - Properties - Methods - Constructor] And Constants
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

    #region Part 05 Namespace Members - Interface

    #region Part 01 [Interface Is Code Contruct]
    public interface Ivechile
    {
        public void Accelerate();
    }
    public interface IFlyable
    {
        public void Accelerate();
    }
    public class Car
    {

    }
    public class Airplane
    {

    }
    public class BMWCar : Car, Ivechile //BMWCar class Inherit From Car Class (BMWCar is a Car), And Implement IVechile Interface behaviour (Accelerate)
    {
        public void Accelerate()
        {
            throw new NotImplementedException();
        }
    }
    public class F16Airplane : Airplane, Ivechile, IFlyable // F16Airplane class Inherit From Airplane Class (F16Airplane is a Airplane), And Implement IVechile,Iflyable Interfaces behaviours (Accelerate), (Accelerate)
                                                            // If The Implementation Of The Two Behaviours Are The Same, So You Can Implement Only one Behaviour Inside Class Represent The Two Behaviours [Methods] [Accelerate].
                                                            // If The Implementation Of The Two Behaviours Are Different, So You Must Implement The Two Behaviours Inside The Class.
    {
        void Ivechile.Accelerate()
        {
            throw new NotImplementedException();
        }
        void IFlyable.Accelerate()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Part 02 [What Can You Write Inside Interface]
    public interface IExample
    {
        //1- Signature For Method [ MethodName - Parameters - ReturnType]
        public void Example();

        //2- Signature For Property [ Property Apply Encapsulation, By Make Access To Private Fields/Attributes Throw Public Property Which Contain Getter And Setter Methods Or Getter Only ],
        // This [Set & Get] Not Set Or Get Any Thing, The Class Or Struct That Implement This Interface Is Make The Implementation Of Those Methods
        public int MyProperty { get; set; }

        //3- Default Implemented Method [ Starts With C# 8.0 ]
        // This Feature, Because If I Have Like (BMW, Mercedes, Toyota) Classes, Which Have The Same Accelerate Calculation And Implement The Same Interface [Ivechile], So I Make Default Implemented Method ( public void Accelerate(){ // Logic } ) In The Ivechile Interface, To Avoid Repeat Same Implementation Of Method In Each Class 
        public void Example2()
        {
            if (MyProperty == 1)
            {
                Console.WriteLine("Any Thing!");
            }
        }

        //4- Static Members [ Methods - Property - Fields (Constant) - Event ] [ Starts With C# 8.0 ]
        static decimal PI = 3.14m;// Static Constant Field
        #endregion

    #region Part 03 [Allowed Access Modifiers Inside Interface]
        //All Access Modifiers Except [ Private & File ].
        /*
             * 1- Private Protected
             * 2- Protected
             * 3- Internal
             * 4- Internal Protected
             * 5- Public [Default]
         */
        #endregion

    #endregion

    }
}
