namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.freamchild = new System.Windows.Forms.Panel();
            this.freamcontrol = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.freamcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // freamchild
            // 
            this.freamchild.AutoScroll = true;
            this.freamchild.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.freamchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.freamchild.Location = new System.Drawing.Point(0, 0);
            this.freamchild.Name = "freamchild";
            this.freamchild.Size = new System.Drawing.Size(1028, 597);
            this.freamchild.TabIndex = 0;
            this.freamchild.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.freamchild_MouseDoubleClick);
            // 
            // freamcontrol
            // 
            this.freamcontrol.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.freamcontrol.Controls.Add(this.comboBox2);
            this.freamcontrol.Controls.Add(this.label2);
            this.freamcontrol.Controls.Add(this.label1);
            this.freamcontrol.Controls.Add(this.comboBox1);
            this.freamcontrol.Controls.Add(this.textBox1);
            this.freamcontrol.Controls.Add(this.txtMatrix);
            this.freamcontrol.Controls.Add(this.button2);
            this.freamcontrol.Controls.Add(this.button1);
            this.freamcontrol.Dock = System.Windows.Forms.DockStyle.Left;
            this.freamcontrol.Location = new System.Drawing.Point(0, 0);
            this.freamcontrol.Name = "freamcontrol";
            this.freamcontrol.Size = new System.Drawing.Size(279, 597);
            this.freamcontrol.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(66, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firt point";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(201, 457);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(5, 272);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(271, 170);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "            Dạng của Ma Trận trọng lượng\r\n        1          2         3         " +
    "4       etc\r\n1\r\n\r\n2\r\n\r\n3\r\n\r\n4  \r\netc\r\n";
            // 
            // txtMatrix
            // 
            this.txtMatrix.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrix.Location = new System.Drawing.Point(4, 4);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatrix.Size = new System.Drawing.Size(272, 262);
            this.txtMatrix.TabIndex = 2;
            this.txtMatrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 510);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 597);
            this.Controls.Add(this.freamcontrol);
            this.Controls.Add(this.freamchild);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuật Toán";
            this.freamcontrol.ResumeLayout(false);
            this.freamcontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel freamchild;
        private System.Windows.Forms.Panel freamcontrol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

