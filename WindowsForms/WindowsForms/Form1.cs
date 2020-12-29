using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ListData listData = ListData.Instance;

                List<string> viewList = listData.list;

                listBox.Items.Add(viewList[cnt]);

                cnt++;
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                listBox.Items.Add("마지막 목록이 끝났습니다. ");

                return;
            }
        }
    }
}
