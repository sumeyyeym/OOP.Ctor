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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //burası bunun için bir örnek. her projede yer alır.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //class içerisinde class adıyla aynı mettot oluşturulursa bu constructur yani yapıcı metot olmuş olur. formlar arası data aktarımında en işe yarar yapıdır.
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(); //form1 içerisinden form2ye müdahale ediyoruz
            Form2 frm1 = new Form2("Bilge adam");
            Form2 frm2 = new Form2((int)nudRed.Value, (int)nudBlue.Value, (int)nudGreen.Value);
            //frm.Text = "Bilge Adam";

            //frm.label1.Text = "Bilge Adam"; //burayı ilk başta yazdığımızda hata verir çünkü label private özellikte. Bu sebeple tasarım kısmmında özelliklerden modifiers'den public ayarla

            //yukarıdaki iki yapı da hatalı uygulama. çünkü bir formdan diğer formun özelliklerini ve süreçlerini yönetmek hatalara sebep olacaktır.
            //frm.Show();
            //frm1.Show();
            frm2.ShowDialog();// bu şekilde yazarsak yalnızca bir tane form ekranı açacaktır. show yazıldığı takdirde tıklanıldığı kadarını açar.
        }
    }
}
