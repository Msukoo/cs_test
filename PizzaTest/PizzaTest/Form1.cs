using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTest
{
    public partial class Form1 : Form
    {
        public delegate int delFrncDow_Edge(int i); //반환값과 인자값타입을 맞춰서 delegate를 생성한다
        
        int iTotalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {

            delFrncDow_Edge delDow = new delFrncDow_Edge(fDow); //변수선언하듯이 new로 생성, 생성할 함수를 인자값으로 넣어준다
            delFrncDow_Edge delEdge = new delFrncDow_Edge(fEdge);
            int iDowOrder = 0;
            int iEdgeOrder = 0;

            //도우선택
            if (radiobread1.Checked)
            {
                iDowOrder=1;
            }else if (radiobread2.Checked)
            {
                iDowOrder = 2;
            }
            //delDow(iDowOrder);

            //엣지선택
            if (radioEdge1.Checked)
            {
                iEdgeOrder = 1;
            }
            else if (radioEdge2.Checked)
            {
                iEdgeOrder = 2;
            }
            //delEdge(iEdgeOrder);

            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge); //콜백함수를 이용해서 변수와 delegate함수 자체를 넣어줌
        }

        #region Function
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1){
                iPrice = 10000;
                strOrder = string.Format("오리지널 도우를 선택했습니다. ( {0}원 )", iPrice.ToString());
            }else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("씬 도우를 선택했습니다. ( {0}원 )", iPrice.ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }

            lBoxOrder.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }

        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("리치골드 엣지를 선택했습니다. ( {0}원 )", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("치즈크러스트 엣지를 선택했습니다. ( {0}원 )", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }

            lBoxOrder.Items.Add(strOrder);
            return iTotalPrice += iPrice;
        }

        public int fCallBackDelegate(int i, delFrncDow_Edge dFunction)
        {
            return dFunction(i);
            //한번 더 거침
        }
        #endregion
    }
}
