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

namespace WorkThread
{
    public partial class Play : Form
    {
        string _strPlayerName = string.Empty;

        Thread _thread = null;

        public Play()
        {
            InitializeComponent();
        }

        public void fThreadStart()
        {
            //_thread = new Thread(new ThreadStart(Run)); //ThreadStart 델리게이트 타입 객체 생성 후 함수를 넘김

            //_thread = new Thread(Run);  //컴파일러가 델리게이트 객체를 추론해서 생성 후 함수를 넘김(new Thread 생략)

            _thread = new Thread(delegate () { Run(); }); //익명메소드로 델리게이트라고 알려주고 실행

            _thread.Start();
        }

        private void Run()
        {
            //UI가 자신이 만들어진 Thread가 아닌 다른 Thread가 접근할 경우 cross Thread발생
            //CheckForIllegalCrossThreadCalls = false;

            int iVar = 0;

            Random rd = new Random();
            while (progressBar1.Value < 100)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(delegate ()
                    {
                        iVar = rd.Next(1, 11);
                        if (progressBar1.Value + iVar > 100)
                        {
                            progressBar1.Value = 100; //while문 종료
                        }
                        else
                        {
                            progressBar1.Value += iVar;
                        }

                        lblProcess.Text = string.Format("진행상황 : {0}%", progressBar1.Value);

                        this.Refresh();
                        
                    }));
                    Thread.Sleep(300); //0.3초
                }
                
            }
        }

        public Play(string strPlayerName)
        {
            InitializeComponent();
            lblPlayerName.Text = _strPlayerName = strPlayerName;
        }

        
    }
}
