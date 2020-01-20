using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace EdikKursch2
{
    public partial class Form1 : Form
    {
        readonly string filepath = Environment.CurrentDirectory + "\\Phones.xml";
        double cur_balance;
        string cur_number;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        public Form1()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            PanelSecond.Visible = false;
            if (!System.IO.File.Exists(filepath))
            {
                MessageBox.Show("File do not exists");
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings
                {
                    Indent = true,
                    NewLineOnAttributes = true
                };
                using (XmlWriter xmlWriter = XmlWriter.Create("Phones.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Records");
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Close();
                    Add_Test_Numbers();

                }
                MessageBox.Show("File created");
            }
         
        }

        public void Add_Test_Numbers()
        {
            string[] N = new string[5] { "+380506571133", "+380504215431", "+380672353451", "+380679983654", "+380501133989" };
            string[] Na = new string[5] { "Петренко", "Васильев", "Зубов", "Колбов", "Тарасов"};
            double[] B = new double[5] { 10.00, 100.45, 200.11, 54.56, 25.35 };
            XDocument doc = XDocument.Load(filepath);
            XElement school = doc.Element("Records");
            for (int i = 0; i < 5; i++)
            school.Add(new XElement("Record",
                       new XElement("Surname", Na[i]),
                       new XElement("Number", N[i]),
                       new XElement("Balance", B[i])));
            doc.Save(filepath);
        }

        public void Update_info()
        {
            XDocument doc = XDocument.Load(filepath);
            XElement root = doc.Element("Records");
            foreach (XElement record in root.Elements("Record").ToList())
                if (record.Element("Number").Value == cur_number)
                {
                    LabelInfo.Text = "Номер: " + record.Element("Number").Value + "\nПользователь: " +
                            record.Element("Surname").Value + "\nБаланс: " + record.Element("Balance").Value + "грн";
                    cur_balance = Convert.ToDouble(record.Element("Balance").Value);
                    cur_number = record.Element("Number").Value;
                }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!maskedTextBox1.MaskCompleted)
                MessageBox.Show("Некорректно введен номер", "Ошибка");
            else
            {
            string Search_Number = maskedTextBox1.Text;

            XDocument doc = XDocument.Load(filepath);
            XElement root = doc.Element("Records");
            foreach (XElement record in root.Elements("Record").ToList())
                if (record.Element("Number").Value == Search_Number)
                {
                    LabelInfo.Text = "Номер: " + record.Element("Number").Value + "\nПользователь: " +
                            record.Element("Surname").Value + "\nБаланс: " + record.Element("Balance").Value + "грн";
                        cur_balance = Convert.ToDouble(record.Element("Balance").Value);
                        cur_number = record.Element("Number").Value;
                        PanelFirst.Visible = false;
                        PanelSecond.Visible = true;
                        maskedTextBox1.Text = "";
                    found = true;
                }
            if (!found) MessageBox.Show("Номер не найден", "Ошибка");
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Button_2_Next_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2P.Text) > 1000)
            {
                MessageBox.Show("Превышена сумма пополнения. Введите корректную сумму", "Ошибка");
                textBox2P.Text = "";
            }
            else
            {
                double new_balance = Convert.ToDouble(textBox2P.Text) - Convert.ToDouble(textBox2P.Text) * 0.01 + cur_balance;
                XDocument doc = XDocument.Load(filepath);
                XElement root = doc.Element("Records");
                foreach (XElement record in root.Elements("Record").ToList())
                {
                    if (record.Element("Number").Value == cur_number)
                    {
                        record.Element("Balance").Value = new_balance.ToString();
                    }
                }
                textBox2P.Text = "";
                doc.Save(filepath);
                MessageBox.Show("Счет успешно пополнен. Новый баланс: " + new_balance, "Счет пополнен");
                PanelSecond.Visible = false;
                PanelFirst.Visible = true;
                LabelInfo.Text = "";
            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            PanelSecond.Visible = false;
            PanelFirst.Visible = true;
            LabelInfo.Text = "";
            textBox2P.Text = "";
            maskedTextBox1.Text = "";
        }

    }
}
