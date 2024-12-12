using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicDiary.Class
{
    public class Users
    {


        private int ID_;
        private string Name_;
        private string Surname_;
        private string Patronymic_;
        private string JobTitle_;
        private string Login_;
        private string Password_;

         public Users(int ID , string Name, string Surname, string Patronymic, string JobTitle, string Login, string Password)
        {
            ID_ = ID;
            Name_ = Name;
            Surname_ = Surname;
            Patronymic_ = Patronymic;
            JobTitle_ = JobTitle;
            Login_ = Login;
            Password_ = Password;
        }
        

        public int ID { get {return ID_; } }
        public string Name { get { return Name_; } }
        public string Surname { get { return Surname_; } }
        public string Patronymic { get { return Patronymic_; } }
        public string JobTitle { get { return JobTitle_; } }
        public string Login { get { return Login_; } }
        public string Password { get { return Password_; } }


    }

    
}
