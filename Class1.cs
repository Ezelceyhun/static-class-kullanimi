using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace static_class_kullanımı
{
    internal class Class1
    {
        public static int sayi {  get; set; }
        public static void metot()
        {
            MessageBox.Show("metot çağırıldı!");
        }
    }
}
