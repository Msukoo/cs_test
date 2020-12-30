using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkThread2
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartWork();
        }

        public void StartWork()
        {
            Thread _thread1 = new Thread(new ThreadStart(Work));
            _thread1.Start();
            Thread _thread2 = new Thread(new ThreadStart(Work));
            _thread2.Start();
        }
        public void Work()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate ()
                {
                    workView.Items.Add(string.Format("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId));

                    Thread.Sleep(3000);

                    workView.Items.Add(string.Format("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId));
                }));
             }
            
      
        }
    }
}
