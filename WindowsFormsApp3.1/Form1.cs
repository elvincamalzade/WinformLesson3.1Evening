using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<string> cars = new List<string>
            //{
            //    "Audi",
            //    "Ferrari",
            //    "Hyundai",
            //    "Mercedes"
            //};

            //listBox1.DataSource = cars;

            listBox1.SelectionMode = SelectionMode.MultiExtended;

            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Id=1,
                    Name="Mercedes"
                },
                new Car
                {
                    Id=2,
                    Name="Ferrari"
                },
                new Car
                {
                    Id=3,
                    Name="Cadillac"
                },
            };

            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";
            //listBox1.DataSource = cars;

            listBox1.Items.Add(new Car
            {
                Name = "Mercedes"
            });
            listBox1.Items.Add(new Car
            {
                Name = "Ferrari"
            });

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //List<string> fruits = new List<string>
            //{
            //    "Apple",
            //    "Mango",
            //    "Magnolia",
            //    "PineApple"
            //};

            //listBox1.DataSource = fruits;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem as Car)?.Name;

            var obj = listBox1.SelectedItem;
            try
            {
                listBox1.Items.Remove(obj);
                listBox2.Items.Add(obj);
                listBox1.SelectedItem = null;
            }
            catch (Exception)
            {
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(
                new Car
                {
                    Name = textBox1.Text
                }
                );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in listBox1.SelectedItems)
            {
                var obj = item as Car;
                stringBuilder.Append($"\n {obj?.Name}");
            }

            label1.Text = stringBuilder.ToString();

        }
    }
}
