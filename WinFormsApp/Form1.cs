using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        
        private void InitializeCustomComponents()
        {
            
            Button btn = new Button();
            btn.Text = "Натисни мене";
            btn.Location = new System.Drawing.Point(50, 50); 
            btn.Size = new System.Drawing.Size(120, 40);     

            
            btn.Click += Btn_Click;

            
            this.Controls.Add(btn);
        }

        
        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привіт! Кнопка натиснута.");
        }
    }
}
