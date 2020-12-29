using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class ListData
    {
        public List<string> list;

        private void SetList()
        {
            if (list == null)
            {
                list = new List<string>();
                list.Add("blue");
                list.Add("Yellow");
                list.Add("red");
            }
        }

        private ListData()
        {
            SetList();
        }
        //인스턴스 객체
        private static ListData _instance;

        //객체반환 함수
        public static ListData Instance
        {
            get
            {
                if (_instance == null) _instance = new ListData();
                return _instance;
            }
        }
    }
}
