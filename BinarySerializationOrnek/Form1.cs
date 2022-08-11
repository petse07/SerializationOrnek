using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serializedbutton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                Name = AdtextBox.Text,
                Phone = telefontextBox.Text,
                DoB = dateTimePicker1.Value,
                Department = departmantextBox.Text,
                Salary = Convert.ToInt32(maastextBox.Text),
                additonalInfo = "Serileþme istemiyoruz"

            };

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsout = new FileStream("employee.binary", FileMode.Create, FileAccess.Write, FileShare.None);

            try 
            {
                using (fsout)
                {
                    bf.Serialize(fsout, emp);
                    Sonuclabel.Text = "Bilgiler Serilize Edildi.";
                    Sonuclabel.Visible = true;
                }
            }

            catch(Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }

        }
    }
}