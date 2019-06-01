/* Disclaimer: These examples and comments from these programs are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
/*In this example, we will define a custom type named UnitConverter—
  a class that serves as a blueprint for unit conversions: */
public class UnitConverter
{
    /*A type contains data members and function members.
     * The data member of UnitConverter is the field called ratio.
     * The function members of UnitConverter are the Convert method and the UnitConverter’s constructor. */

    /*A beautiful aspect of C# is that predefined types and custom types have few differences. 
     * The predefined int type serves as a blueprint for integers. */

    int ratio;                                                      // Field
    public UnitConverter(int unitRatio) { ratio = unitRatio; }      // Constructor
    public int Convert (int unit) { return unit * ratio; }          // Method
}

class Test
{
    static void Main()
    {
        /*The new operator creates instances of a custom type.
         * We created and declared an instance of the UnitConverter type with this next statement: */
        UnitConverter feetToInchesConverter = new UnitConverter(12);    // Defines 12 inches in a foot
        /*Immediately after the new operator instantiates an object, the object’s constructor is called to perform initialization. 
         * A constructor is defined like a method, except that the method name and return type are reduced to the name of the enclosing type */
        UnitConverter milesToFeetConverter = new UnitConverter(5280);   // Defines 5280 feet in a mile

        Console.WriteLine(feetToInchesConverter.Convert(30));       // 360
        Console.WriteLine(feetToInchesConverter.Convert(100));      // 1200
        Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));    // 63360
        Console.ReadKey();
    }
}
