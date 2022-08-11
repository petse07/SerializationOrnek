using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace XmlSerializationOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xmlserializedbutton_Click(object sender, EventArgs e)
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

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsout = new FileStream("employee.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fsout)
                {
                    xs.Serialize(fsout, emp);
                    Sonuclabel.Text = "Bilgiler Serilize Edildi.";
                    Sonuclabel.Visible = true;

                    AdtextBox.Text = "";
                    telefontextBox.Text = "";
                    //dateTimePicker1.Value = "";

                    departmantextBox.Text = "";

                    maastextBox.Text = "";
                }
            }

            catch (Exception ex)
            {
                ex.Message.ToString();
                Sonuclabel.Text = "Bir hata oluþtu";
                Sonuclabel.Visible = true;
            }
        }

        private void xmldeserializedbutton_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();


            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fsin = new FileStream("employee.xml", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fsin)
                {
                    emp = (Employee)xs.Deserialize(fsin);

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