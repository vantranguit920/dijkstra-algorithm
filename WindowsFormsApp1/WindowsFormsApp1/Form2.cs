using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public delegate void Login(string name, string away,bool flag);
        public event Login LoginEvent;
        bool flag=false;

        public Form2()
        {
            InitializeComponent();
            btnok.Click += Btnok_Click;
            btncancel.Click += Btncancel_Click;
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            int z;
            if (txtname.Text == string.Empty || txtaway.Text == string.Empty||!int.TryParse(txtaway.Text,out z))
            {
                MessageBox.Show("Thông tin chưa đầy đủ, hoặc trường Khoảng cách không phải là số !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
                //return ;
                
            }
            else
            {
                string name = txtname.Text;
                string away = txtaway.Text;

                if (LoginEvent != null)
                {
                    flag = true;
                    LoginEvent(name, away, flag);
                    this.Close();
                    flag = false;
                }
                else
                {
                    this.Close();
                }
            }
            
        }

        
    }
}
