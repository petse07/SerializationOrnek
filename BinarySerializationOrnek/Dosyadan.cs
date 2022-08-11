using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerializationOrnek
{
    public partial class Dosyadan : Form
    {
        public Dosyadan()
        {
            InitializeComponent();
        }

        IFormatter formatter = new BinaryFormatter();

        private void dosyayayazbutton_Click(object sender, EventArgs e)
        {
            Tutorial obj = new Tutorial();

            obj.ID = 1;
            obj.Name = ".Net";

            Stream stream = new FileStream(@"C:\Users\HP\Desktop\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();
        }

        private void dosyadanokubutton_Click(object sender, EventArgs e)
        {
            Stream streamoku = new FileStream(@"C:\Users\HP\Desktop\ExampleNew.txt", FileMode.Open, FileAccess.Read);

            Tutorial objnew = (Tutorial)formatter.Deserialize(streamoku);

            MessageBox.Show("ID: "+objnew.ID);
            MessageBox.Show("Adı: " + objnew.Name);

        }
    }
}
