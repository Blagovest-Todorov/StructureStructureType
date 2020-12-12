using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _2.StructureType
{
    class Program
    {
        static void Main(string[] args)
        {
            // StructureType cannot be inhereted , Structure Type = struct type !!
            // struct type is ValueTuple type;
            // sruct type is created with keyword struct - > we suse them to we use them to encapsulate data;

        
        }
        public struct Coords 
        {
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public double X { get; }
            public double Y { get; }

            public override string ToString() => $"({X}, {Y})";
            //Struct provide litte or not behavior,  struct have valeu semantics, 
            // if you want to provide a behaviour use class ,  class types have behaviout sematntics , class types are reference Semantics
            // .Net uses Structure types to represent a number, (interge or real, type) , a boolean value ;, aunicoede character! or 
            // a time instance .  struct type can not be inhereted !!
            //  all data members of readonly Structure must me read-only !
            // a struct cant implement an interface
            // structs are used for storage of data !
            //value type lieves on the stack for better performance
            // value type dont have inheritance !
            // structure have more limitations than the class, 
            // Structs are value type, while classes are reference type, 
            // structs are allocated on the stack //
            // Structure Type are vlaue type and are created on the stack
            // all struct type inherit from System.ValueType;
            // primitve data types int, bool, flaor date struc type.
            // struct type  do not support inherritance
            //structures can implement an interface, a struct can be assignes a null value 
            // The structure is declared with the struct keyword.
            //Structures can contain constructors, constants, fields, methods, properties, indexers, operators, events, and nested types
            //
            //
        }
    }
}
