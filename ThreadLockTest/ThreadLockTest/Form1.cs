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

namespace ThreadLockTest
{
    public partial class Form1 : Form
    {
        private object lockObject = new object();
        int iNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetNum_Click(object sender, EventArgs e)
        {

            int number = (int)numOfNum.Value;
            
            for (int i = 0; i < number; i++)
            {
                new Thread(() => GiveNumber()).Start();
                
            }
        }

        public void GiveNumber()
        {
            //lock (lockObject)
            //{
                if (this.InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate ()
                    {
                        iNumber++;
                        Thread.Sleep(3000);
                        lNumberView.Items.Add(string.Format("{0}번을 부여합니다.", iNumber));
                        
                        //lNumberView.Items.Add(string.Format("{0}번 입장합니다..", iNumber));
                        
                        //lNumberView.Items.Add(string.Format("{0}번 안녕히가세요..", iNumber));
                    });
                }
            //}
            

        }




    }
}
