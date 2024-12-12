using ElectronicDiary.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicDiary
{
  
    public partial class Ticher : Form
    {
        private Users currentUser;
        public Ticher(Users user)
        {
            InitializeComponent();
            currentUser = user;
            LoadNameAndTitle();
        }
        public void LoadNameAndTitle()
        {
            FIO.Text = $"{currentUser.Name} {currentUser.Surname} {currentUser.Patronymic}";
        }
        public void LoadJobTitle()
        { 
        
        
        
        }
    }
}
