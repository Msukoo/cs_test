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
        Thread _thread = null;
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
            Work work = new Work();
            for(int i=0; i<3; i++)
            {
                //work.fThreadStart();
                _thread = new Thread(new ThreadStart(work.fWork));
                _thread.Start();

            }
            
        }
        
    }
}
