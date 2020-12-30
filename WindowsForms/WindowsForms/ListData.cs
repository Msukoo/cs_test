using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class ListData
    {
        public List<User> list;

        private void SetList()
        {
            if (list == null)
            {
                list = new List<User>();

                list.Add(NewUser("minsu", 29, "F", "송파구"));
                list.Add(NewUser("dasom", 23, "F", "광진구"));
                list.Add(NewUser("bonmin", 22, "M", "송파구"));
                list.Add(NewUser("Yoogin", 28, "F", "김포시"));
                list.Add(NewUser("soyoung", 31, "F", "수정구"));
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

        public User NewUser(string name, int age, string gender, string address)
        {
            User u = new User();
            u.Name = name;
            u.Age = age;
            u.Gender = gender;
            u.Address = address;
            return u;
        }
    }
}
