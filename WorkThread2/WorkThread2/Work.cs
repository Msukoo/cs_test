using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WorkThread2
{
    class Work
    {
        
        public void fThreadStart()
        {
            //_thread = new Thread(new ThreadStart(fWork));
            //_thread.Start();
        }
        public void fWork()
        {
            Console.WriteLine(string.Format("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId));

            Thread.Sleep(3000);

            Console.WriteLine(string.Format("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId));
            

        }
    }
}
