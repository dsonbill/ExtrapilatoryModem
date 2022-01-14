using System;
using System.Collections.Generic;
using System.Threading;

namespace ExtrapilatoryModem
{
    class Program
    {
        static void Main(string[] args)
        {
            ACReceiver receiver = new ACReceiver();
            ACMemory memory = new ACMemory();

            receiver.signal = 5.16692728888f;
            receiver.degree = 187f;
            //receiver.offset = 6;

            for (int i = 0; i < int.MaxValue; i++)
            {
                memory.SetMemory(memory.Transpose());
                Console.Clear();
                foreach (KeyValuePair<char, float> valuePair in memory.Data)
                {
                    Console.WriteLine(valuePair.Key + ": " + valuePair.Value);
                }
                //Console.WriteLine(memory.Transpose());
                Thread.Sleep(40);
            }
        }
    }
}
