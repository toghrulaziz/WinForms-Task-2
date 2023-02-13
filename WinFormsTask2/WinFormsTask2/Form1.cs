using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinFormsTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Person p = new Person { Name = textBox_name.Text, Surname = textBox_surname.Text, FatherName = textBox_fathername.Text, Country = textBox_country.Text, City = textBox_city.Text, Phone = textBox_phone.Text, DT = dateTimePicker1.Value };


            RadioButton radiobuttonmale = this.radioButton_male;
            RadioButton radiobuttonfamale = this.radioButton_famale;

            if (radiobuttonmale.Checked)
            {
                p.Gender = "male";
            }
            else
            {
                p.Gender = "famale";
            }

            if (radiobuttonfamale.Checked)
            {
                p.Gender = "famale";
            }
            else
            {
                p.Gender = "male";
            }

            string json = JsonConvert.SerializeObject(p);

            File.WriteAllText($"{p.Name}", json);
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            string name = getname_txtbox.Text;

            string json = File.ReadAllText($"{name}");

           
            Person person = JsonConvert.DeserializeObject<Person>(json);

            

            textBox_name.Text = person.Name;
            textBox_surname.Text = person.Surname;
            textBox_fathername.Text = person.FatherName;
            textBox_country.Text = person.Country;
            textBox_city.Text = person.City;
            textBox_phone.Text = person.Phone;
            dateTimePicker1.Value = person.DT;

            if(person.Gender == "male")
            {
                radioButton_male.Checked = true;
            }
            else
            {
                radioButton_male.Checked = false;
            }

            if (person.Gender == "famale")
            {
                radioButton_famale.Checked = true;
            }
            else
            {
                radioButton_famale.Checked = false;
            }

        }
    }
}
