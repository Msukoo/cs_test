using System;
using System.Threading;

namespace ThreadLockTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NumberTicket nt = new NumberTicket();
            for(int i=0; i< 10; i++)
            {
                new Thread(new ThreadStart(nt.GiveNumber)).Start();
            }
            
        }

        class NumberTicket
        {
            public int nextTiketNum = 1000;
            public object tiketLock = new object();
            public void GiveNumber()
            {
                lock (tiketLock)
                {
                    nextTiketNum++;
                    Thread.Sleep(300);
                    Console.WriteLine(string.Format("티켓번호 : {0}", nextTiketNum));
                }
                /*
                nextTiketNum++;
                Thread.Sleep(300);
                Console.WriteLine(string.Format("티켓번호 : {0}", nextTiketNum));
                */

            }
        }

    }
}
