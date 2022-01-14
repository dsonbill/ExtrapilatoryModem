using System;
using System.Threading;

namespace ExtrapilatoryModem
{
    class Program
    {
        static void Main(string[] args)
        {
            ACReceiver receiver = new ACReceiver();

            receiver.signal = 5.16692728888f;
            receiver.degree = 187f;
            //receiver.offset = 6;

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine(receiver.Transpose());
                Thread.Sleep(40);
            }
        }
    }
}
