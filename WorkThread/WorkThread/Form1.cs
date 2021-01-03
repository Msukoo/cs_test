using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkThread
{
    public partial class Form1 : Form
    {
        int _locationX = 0;
        int _locationY = 0;

        private enum enumPlayer
        {
            지민,
            정국,
            진,
            슈가,
            뷔,
        }

        public Form1()
        {
            InitializeComponent();

            _locationX = this.Location.X; //form1의 위치값
            _locationY = this.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _locationX = this.Location.X + this.Size.Width ; //Play UI위치값지정하기위한 기준
            _locationY = this.Location.Y;

            for(int i=0; i<numberPlayerCount.Value; i++)
            {
                Play pl = new Play(((enumPlayer)i).ToString());
                pl.Location = new Point(_locationX, _locationY+pl.Height*i);
                pl.Show();

                pl.fThreadStart();
            }

            
        }
    }
}
