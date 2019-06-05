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
    public partial class Form1 : Form
    {
        
        #region var
        bool isduble = true;
        int y = 0;
        int x = 0;
        List<int> listname;
        int name = 1;
        Point p1, p2;
        int sum=0;
        int[] len,pr,s;//
        List<int> list;//
        string pathmin;//
        int n=0;
        int[,] matrix;
        string namebtn;
        Bitmap bm;
        Graphics gr;
        List<Point> pontss;//
        bool isContructer = true;
        List<Button> btns;
        #endregion
        public Form1()
        {
            InitializeComponent();
            list = new List<int>();
            listname = new List<int>();
            pontss = new List<Point>();
            bm = new Bitmap(freamchild.Width,freamchild.Height);
            gr = Graphics.FromImage(bm);
            this.SetStyle(ControlStyles.UserPaint, true);
            btns = new List<Button>();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
           
        }
        

        #region menthod

        private void Fm_LoginEvent(string name, string away, bool flag)
        {
            if (flag)
            {
                foreach(Button bt in btns)
                {
                    if (bt.Name.Equals(name)&&(!namebtn.Equals(name)))
                    {
                        matrix[int.Parse(name)-1, int.Parse(namebtn)-1] = int.Parse(away);
                        matrix[int.Parse(namebtn)-1, int.Parse(name)-1] = int.Parse(away);
                        p2 = new Point(bt.Location.X+30,bt.Location.Y+30);
                        Point pp = new Point(p1.X + (p2.X - p1.X) / 2, p1.Y + (p2.Y - p1.Y) / 2);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);
                        Pen p = new Pen(Color.Red);
                        gr.DrawLine(p, p1, p2);
                        freamchild.BackgroundImage = (Bitmap)(bm.Clone());
                        sum += int.Parse(away);
                        
                        RectangleF rectf = new RectangleF(p1.X + (p2.X - p1.X) / 2, p1.Y + (p2.Y - p1.Y) / 2, 90, 50);
                        gr.DrawString(away, Font = new Font("Tahoma", 8), Brushes.Black, rectf);
                        gr.Flush();
                        freamchild.BackgroundImage = (Bitmap)(bm.Clone());
                    }
                }
                    
                    
                  
            }
        }

        

        

        private void freamchild_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isduble)
            {
                x = e.X;
                y = e.Y;
                n++;
                Cyclebutton btn = new Cyclebutton() { Width = 50, Height = 50, Font = new Font("Consolas", 15, FontStyle.Bold), BackColor = Color.Red };
                btn.Text = name.ToString();
                btn.Name = name.ToString();
                btn.FlatStyle = FlatStyle.Flat;
                btns.Add(btn);
                btn.Click += Btn_Click;
                btn.Location = new Point(x, y);
                freamchild.Controls.Add(btn);

                //listname.Add(name);

                comboBox1.Items.Add(name);
                comboBox2.Items.Add(name);
                //comboBox1.DataSource = null;
                //comboBox1.DataSource =listname;
                //comboBox2.DataSource = null;
                //comboBox2.DataSource = listname;


                name++;
            }
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if (isContructer)
            {
                matrix = new int[n,n];
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        matrix[i,j] = 0;
                    }
                }
                isContructer = false;
                isduble = false;
            }
            Form2 fm = new Form2();
            p1 = new Point(((Button)sender).Location.X+30, ((Button)sender).Location.Y+30);
            namebtn = ((Button)sender).Name.ToString();
            fm.LoginEvent += Fm_LoginEvent;

            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int firt=0;
            int end = 0;
            if (comboBox2.SelectedItem != null)
            {
                firt = int.Parse(comboBox2.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Hãy chọn điểm khởi đầu !");
                return;
            }
            if (comboBox1.SelectedItem != null)
            {
                end = int.Parse(comboBox1.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Hãy chọn điểm kết thúc !");
                return;
            }
            if (firt > end)
            {
                int l = firt;
                firt = end;
                end = l;
            }
            if (pr!=null)
            {
                pr = null;
                s = null;
                len = null;
                foreach (int j in list)
                {

                    foreach (Button bt in btns)
                    {
                        if (bt.Name.Equals(j.ToString()))
                        {
                            bt.BackColor = Color.Red;
                            //pontss.Add(new Point(bt.Location.X + 30, bt.Location.Y + 30));
                        }
                    }

                }
                Pen pw = new Pen(Color.Red);


                for (int i = 0; i < (pontss.Count - 1); i++)
                {
                    gr.DrawLine(pw, pontss[i], pontss[i + 1]);
                }

                freamchild.BackgroundImage = (Bitmap)(bm.Clone());
                this.Refresh();
                list = new List<int>();
                pathmin = string.Empty;
                pontss = new List<Point>();

            }


            if (isContructer)
            {
                matrix = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
                isContructer = false;
            }
            
            txtMatrix.Clear();
            txtMatrix.AppendText("Ta có Ma Trận trọng lượng của Đồ thị \n");
            txtMatrix.AppendText("\n");

            

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    txtMatrix.AppendText(matrix[i,j].ToString()+"     ");
                }
                txtMatrix.AppendText("\n");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0 && i != j)
                    {
                        matrix[i, j] = (sum+1);
                    }

                }
            }
            findminpath(firt,end);
            txtMatrix.AppendText("\n");
            txtMatrix.AppendText("\n");
            for (int i =0; i < n; i++)
            {
                txtMatrix.AppendText((pr[i]).ToString() + "  ");
            }
            txtMatrix.AppendText("\n");
            txtMatrix.AppendText("Đường đi ngắn nhất từ " + firt.ToString() + " đến " +end.ToString()+" là: ");
            txtMatrix.AppendText("\n");
            if (len[end-1] == sum)
            {
                txtMatrix.AppendText("Không tồn tại đường đi !");
                return;
            }
            chuanhoa(pr,firt,end);
            char[] pm = pathmin.ToCharArray();
            pathmin = string.Empty;
            for(int j = (pm.Length - 1); j >= 0; j--)
            {
                pathmin += pm[j];
            }
            txtMatrix.AppendText(pathmin);
            txtMatrix.AppendText("\n");
            txtMatrix.AppendText("Chi phí ít nhất cho đường đi là :   ");
            txtMatrix.AppendText(len[end-1].ToString());

            foreach(int j in list)
            {
                
                foreach (Button bt in btns)
                {
                    if (bt.Name.Equals(j.ToString()))
                    {
                        bt.BackColor = Color.Blue;
                        pontss.Add(new Point(bt.Location.X+30,bt.Location.Y+30));
                    }
                }
                
            }
            Pen p = new Pen(Color.Blue);
           
           
            for(int i = 0; i < (pontss.Count - 1); i++)
            {
                gr.DrawLine(p, pontss[i], pontss[i + 1]);
            }
          
            freamchild.BackgroundImage = (Bitmap)(bm.Clone());
            this.Refresh();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            isduble = true;
            n = 0;
            sum = 0;
            pontss = new List<Point>();
            len = pr = s = null;
            pathmin = string.Empty;
            matrix = null;
            list = new List<int>();
            int kk = comboBox1.Items.Count;
            for (int i = (kk - 1); i >= 0; i--)
            {
                comboBox1.Items.RemoveAt(i);
            }
            for (int i = (kk - 1); i >= 0; i--)
            {
                comboBox2.Items.RemoveAt(i);
            }
            isContructer = true;
            freamchild.Controls.Clear();
            txtMatrix.Clear();
            name = 1;
            btns.Clear();
            gr.Clear(Color.DarkSeaGreen);
            freamchild.BackgroundImage = bm;
            this.Refresh();
        }

       void chuanhoa(int[] path,int firt,int end)
        {
            int k = end-1;
            while (k != (firt-1))
            {
                list.Add(k + 1);
                pathmin += (k + 1).ToString() + ">----";
                k = path[k];
            }
            pathmin += firt.ToString();
            list.Add(firt);
        }
        
        void findminpath(int a, int b)
        {
            sum++;
            int firt = --a, end = --b, k;
            len = new int[n];
            pr = new int[n];
            s = new int[n];
            for (int m = 0; m < n; m++)
            {
                len[m] = sum;
                pr[m] = firt;
                s[m] = 0;
            }
            len[firt] = 0;
            while (s[end] == 0)
            {
                for (k = 0; k < n; k++)
                    if (s[k] == 0 && len[k] < sum)
                        break;
                if (k >= n)
                {
                    break;
                }
                for (int j = 0; j < n; j++)
                {    
                    if (s[j]==0 && len[k] > len[j])
                    {
                        k = j;
                    }
                    
                }
                s[k] = 1;
                for (int j = 0; j < n; j++)
                {    
                    if (s[j]==0 && len[k] + matrix[k,j] < len[j])
                    {
                        len[j] = len[k] +matrix[k,j];      
                        pr[j] = k;                       
                    }
                }

            }


        }

        #endregion



    }
}
