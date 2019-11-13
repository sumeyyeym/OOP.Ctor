using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Constructor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string parametre):this() //ctor + tab tab yaparak çağırdık
        {
            InitializeComponent(); //eğer bu komut ya da yukarıdaki this() komutu olmazsa form1den gönderilen komut çalıştırılamaz ve hata verir, tasarım ekranda gözükmez. çünkü bu metodun içerisinde oradan gelen komutu çalıştırıp RAM'e çıkaracak yapı eksik kalmış olur.
            label1.Text = parametre;
        }

        public Form2(int red, int blue, int green):this()
        {
            this.BackColor = Color.FromArgb(red, blue, green);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
