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
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ListData listData = ListData.Instance;

                List<User> viewList = listData.list;
                dataGridView1.DataSource = viewList;

                for (int i=0; i<viewList.Capacity; i++)
                {
                    listBox.Items.Add(viewList[i].Name);
                }
                                              
            }
            catch (Exception x)
            {
                button1.Enabled = false;
                textBox1.Text = "마지막입니다.";
                Console.WriteLine(x.Message);
            }
        }

        

        
    }
}
