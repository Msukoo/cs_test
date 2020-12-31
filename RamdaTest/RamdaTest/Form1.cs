using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamdaTest
{
    public partial class Form1 : Form
    {
        Action aStepCheck = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aStepCheck = () => label1.Text = string.Format("다음스텝은 {0}, {1}", iNowStep, ((LambdaCase)iNowStep).ToString());
            aStepCheck();

            ButtonColorChange();
        }

        private void ButtonColorChange()
        {
            //이벤트함수에서 색상 변경
            button1.Click += button1_Click;

            //무명메소드
            button2.Click += delegate (object sender, EventArgs e)
            {
                button2.BackColor = Color.Aqua;
            };

            //람다식
            button3.Click +=  (sender, e)=> button3.BackColor = Color.Yellow;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        int iNowStep = 0;
        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();
        private void button4_Click(object sender, EventArgs e)
        {
            Lambda(iNowStep);
            iNowStep++;
            aStepCheck();
        }

        
        private void Lambda(int iCase)
        {
            switch (iCase)
            {
                case (int)LambdaCase.simpleLambda:
                    //식형식람다식
                    delIntFunc dInt = (a, b) => a * b;
                    int iResult = dInt(4, 5);
                    lBoxResult.Items.Add(iResult.ToString());
                    

                    delStringFunc dString = () => string.Format("Lambda 식형식");
                    string strResult = dString();
                    lBoxResult.Items.Add(strResult.ToString());
                    break;

                case (int)LambdaCase.sentenceLambda:
                    //문형식람다식
                    delStringFunc dStringSen = () =>
                    {
                        return string.Format("Lambda 문형식");
                    };
                    String strSenResult = dStringSen();
                    lBoxResult.Items.Add(strSenResult.ToString());
                    break;

                case (int)LambdaCase.genericAnonymous_func:
                    //제네릭형태의 무명메소드

                    //반환값이 있는 형태
                    Func<int, int, int> fInt = (a, b) => a * b; //마지막은 항상 반환값
                    int fIntResult = fInt(4, 5);
                    lBoxResult.Items.Add(fIntResult.ToString());
                    break;

                case (int)LambdaCase.genericAnonymous_action:
                    //반환값 없는 형태
                    Action<string, string> aString = (a, b) =>
                    {
                        string strText = string.Format("인자값 {0}와 {1}를 받았습니다.", a, b);
                        lBoxResult.Items.Add(strText.ToString());
                    };
                    aString("시간", "금");
                    break;

                case (int)LambdaCase.generic_return:
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iNumSum = iGroup.Sum(x => x);
                    lBoxResult.Items.Add(iNumSum.ToString());

                    string[] strGroup = { "aa", "bb", "cc", "dd" };
                    int iLengthSum = strGroup.Sum(x => x.Length);
                    lBoxResult.Items.Add(iLengthSum.ToString());

                    break;

                default:
                    break;
            }
        }
        enum LambdaCase
        {
            simpleLambda = 0, //식형식람다
            sentenceLambda = 1, //문형식람다
            genericAnonymous_func = 2, //제네릭형태의무명메소드함수
            genericAnonymous_action = 3, //제네릭형태의무명메소드액션
            generic_return = 4, //제네릭형태의인자 반환예제


        }

        
    }
}
