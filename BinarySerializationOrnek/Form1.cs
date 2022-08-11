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

                    AdtextBox.Text = "";
                    telefontextBox.Text = "";
                    //dateTimePicker1.Value = "";

                    departmantextBox.Text = "";

                    maastextBox.Text = "";
                }
            }

            catch(Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }

        }

        private void deserializedbutton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
  

            BinaryFormatter bf = new BinaryFormatter();
            FileStream fsin = new FileStream("employee.binary", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    emp = (Employee)bf.Deserialize(fsin);

                    Sonuclabel.Text = "Object DeSerilize Edildi.";
                    Sonuclabel.Visible = true;

                    AdtextBox.Text = emp.Name;
                    telefontextBox.Text = emp.Phone;
                    dateTimePicker1.Value = emp.DoB;

                    departmantextBox.Text = emp.Department;

                    maastextBox.Text = Convert.ToString(emp.Salary);
               



                }
            }

            catch (Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }
        }
    }
}