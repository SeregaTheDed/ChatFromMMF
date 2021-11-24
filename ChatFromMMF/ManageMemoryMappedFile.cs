using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatFromMMF
{
    public static class ManageMemoryMappedFile
    {
        private const int MaxCapacity = 1000;
        private static MemoryMappedFile mmf = MemoryMappedFile.CreateOrOpen("MyChatLaba2", MaxCapacity, MemoryMappedFileAccess.ReadWrite);
        static ManageMemoryMappedFile()
        {
            if (Capacity == 0) 
                Capacity = 4;
        }
        private static void ManageMemoryMappedFileTEST()
        {
            List<bool> list = new List<bool>();
            Capacity = 0;
            var test1 = Capacity;
            list.Add(test1 == Capacity);

            Capacity = 13;
            var test2 = Capacity;
            list.Add(test2 == Capacity);

            Capacity = int.MaxValue;
            var test3 = Capacity;
            list.Add(test3 == Capacity);

            Capacity = uint.MaxValue;
            var test4 = Capacity;
            list.Add(test4 == Capacity);
            list.Count();


        }
        public static uint Capacity
        {
            get
            {
                StringBuilder result = new StringBuilder();
                using (var Accesor = mmf.CreateViewAccessor())
                {
                    byte CurrentSByte;
                    for (int i = 0; i < 4; i++)
                    {
                        Accesor.Read(i, out CurrentSByte);
                        var WithoutZeros = Convert.ToString((CurrentSByte), 2);
                        result.Append(RestoringInsignificantZeros(WithoutZeros));
                    }
                }
                return Convert.ToUInt32(result.ToString(), 2);
            }
            private set
            {
                var BinaryFromInt = Convert.ToString(value, 2);
                var BinaryFromIntWithInsignificantZeros = RestoringInsignificantZeros(BinaryFromInt, 32);
                using (var Accesor = mmf.CreateViewAccessor())
                {
                    for (int i = 0; i < 4; i++)
                    {
                        byte CurrentSByteFromSubstring = Convert.ToByte(BinaryFromIntWithInsignificantZeros.Substring(i * 8, 8), 2);
                        Accesor.Write(i, CurrentSByteFromSubstring);
                    }
                }
            }
        }
        private static string RestoringInsignificantZeros(string BinaryNumberWithoutZeros, int LenOfBinaryNumber = 8)
        {
            return String.Join("", Enumerable.Repeat<string>("0", LenOfBinaryNumber - BinaryNumberWithoutZeros.Length)) + BinaryNumberWithoutZeros;
        }
        public static void Write(string message)
        {
            using (var Accessor = mmf.CreateViewAccessor())
            {
                if ((Capacity + message.Length) > uint.MaxValue)
                    throw new OverflowException("The final capacity exceeded the maximum value of uint");
                var newCapacity = (uint)(Capacity + message.Length);
                for (long i = Capacity, messageIndex = 0; i < newCapacity; i++, messageIndex++)
                {
                    Accessor.Write(i, (sbyte)message[(int)messageIndex]);
                }
                //Accessor.Flush();
                Capacity = newCapacity;
            }
        }
        public static void WriteLine(string message)
        {
            Write(message + "\n\r");
        }
        public static string ReadToEnd()
        {
            using (var read = mmf.CreateViewAccessor())
            {
                StringBuilder sb = new StringBuilder();
                for (uint i = 4; i < Capacity; i++)
                {
                    sbyte c1;
                    read.Read(i, out c1);
                    sb.Append((char)c1);
                }
                return sb.ToString();
            }
        }

    }
}
