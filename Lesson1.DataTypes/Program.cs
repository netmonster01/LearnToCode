using System;

namespace Lesson1.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // The // in c# is a comment. commented code does not get compiled or run.


            // console writeline is the what to write the output.
            Console.WriteLine("Hello World!");
            //
            // Data Measurement         Size
            // Bit                       Single Binary Digit(1 or 0)
            // Byte                      8 bits
            // Kilobyte(KB)              1,024 Bytes
            // Megabyte(MB)              1,024 Kilobytes
            // Gigabyte(GB)              1,024 Megabytes
            // Terabyte(TB)              1,024 Gigabytes
            // Petabyte(PB)              1,024 Terabytes
            // Exabyte(EB)               1,024 Petabytes

            // Reserved Word	.NET Type   Type                                                    Size(bits)                                                      Range(values)
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // byte             Byte        Unsigned integer                                        8                                                               0 to 255
            // sbyte            SByte       Signed integer                                          8                                                               -128 to 127
            // short            Int16       Signed integer                                          16                                                              -32,768 to 32,767
            // ushort           UInt16      Unsigned integer                                        16                                                              0 to 65,535
            // int              Int32       Signed integer                                          32                                                              -2,147,483,648 to 2,147,483,647
            // uint             UInt32      Unsigned integer                                        32                                                              0 to 4294967295
            // long             Int64       Signed integer                                          64                                                              -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // ulong            UInt64      Unsigned integer                                        64                                                              0 to 18,446,744,073,709,551,615
            // float            Single      Single - precision floating point type                  32                                                              -3.402823e38 to 3.402823e38
            // double           Double      Double - precision floating point type                  64                                                              -1.79769313486232e308 to 1.79769313486232e308
            // decimal          Decimal     Precise fractional or integral type that can
            //                               represent decimal numbers with 29 significant digits   128                                                             (+or -)1.0 x 10e-28 to 7.9 x 10e28
            // char             Char        A single Unicode character                              16                                                              Unicode symbols used in text
            // bool             Boolean     Logical Boolean type                                    8                                                               True or False
            // object           Object      Base type of all other types
            // string           String      A sequence of characters
            // DateTime         DateTime    Represents date and time                                                                                                0:00:00am 1 / 1 / 01 to 11:59:59pm 12 / 31 / 9999


            // arrays 

            // hashtables

            // dict

            // lists
            // stops the program and waits for a key to be pressed.
            Console.ReadKey();
        }
    }
}
