using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySerializationOrnek
{
    public partial class JsonForm : Form
    {
        public JsonForm()
        {
            InitializeComponent();
        }

        private void jsonserbutton_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);
            product.Price = 3.99;

            string output = JsonConvert.SerializeObject(product);
            jsonserlabel.Text = output;
            jsonserlabel.Visible = true;
        }

        private void jsondeserbutton_Click(object sender, EventArgs e)
        {
            Product product = JsonConvert.DeserializeObject<Product>(jsonserlabel.Text);
            MessageBox.Show(product.Name);
        }

        private void jsonserfilebutton_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.Name = "Apple";
            product.ExpireDate = new DateTime(2008, 12, 28);
            

            JsonSerializer serializer = new JsonSerializer();
            using(StreamWriter sw = new StreamWriter(@"C:\Users\HP\Desktop\json.json"))
                using(JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
            }

        }

        private void jsondeserfilebutton_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader file = File.OpenText(@"C:\Users\HP\Desktop\json.json"))
            using (JsonReader reader = new JsonTextReader(file))
            {
                Product product = (Product)serializer.Deserialize(reader, typeof(Product));
                MessageBox.Show(product.Name);

            }
        }
    }
}
