using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AutoCompleteText();
        }

        void AutoCompleteText()
        {
            txtAutoCompleteDataBaseValues.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtAutoCompleteDataBaseValues.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            coll.Add("La Paz");
            coll.Add("Cochabamba");
            coll.Add("Santa Cruz");
            coll.Add("Oruro");
            coll.Add("Chuquisaca");
            coll.Add("Tarija");
            coll.Add("Potosi");
            coll.Add("Beni");
            coll.Add("Pando");

            txtAutoCompleteDataBaseValues.AutoCompleteCustomSource = coll;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            comboBox1.Items.Add(new { Text = "Sacaba", Value = "123" });
            comboBox1.Items.Add(new { Text = "Qullacollo", Value = "124" });
            comboBox1.Items.Add(new { Text = "Tiquipaya", Value = "125" });
            comboBox1.Items.Add(new { Text = "Villa", Value = "126" });
            comboBox1.Items.Add(new { Text = "Colcapirhua", Value = "127" });
        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            object i= comboBox1.SelectedItem;

        }

    }
}
