using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 newBook = new Class1();
            Book2 Midnight = new Book2();

            Midnight.Author = textBox1.Text;
            newBook.Author = textBox1.Text;

            string fault = newBook.Author = "John Green";
            string night = Midnight.Author = "Stephenie Meyer";

            if(textBox1.Text == "Stephenie Meyer" || textBox1.Text == "Meyer"
                || textBox1.Text == "Stephen" || textBox1.Text =="stephenie meyer")
            {
                string twilight = string.Format("Author:{0},BookName:{1},PublishDate:{2},BookSold:{3},Genre:{4}", night, Midnight.BookName, Midnight.PublishDate, Midnight.BookSold, Midnight.Genre); //ehnii nom Meyeriin
                string twilight2 = string.Format("Author:{0},BookName:{1},PublishDate:{2},BookSold:{3},Genre:{4}", night, Midnight.BookName2, Midnight.PublishDate2, Midnight.BookSold2, Midnight.Genre2); // daraagiin nom
                listBox1.Items.Add(twilight);
                listBox1.Items.Add(twilight2);
            }
            else if(textBox1.Text == "John Green" || textBox1.Text =="John" ||
                textBox1.Text == "john" || textBox1.Text == "Green")
            {
                string nom1 = string.Format("Author:{0},BookName:{1},PublishDate:{2},BookSold:{3},Genre:{4}", fault, newBook.BookName, newBook.PublishDate, newBook.BookSold, newBook.Genre); // ehnii nom John Green
                string nom2 = string.Format("Author:{0},BookName:{1},PublishDate:{2},BookSold:{3},Genre:{4}", fault, newBook.BookName2, newBook.PublishDate2, newBook.BookSold2, newBook.Genre2); // daraagiin nom
                listBox1.Items.Add(nom1);
                listBox1.Items.Add(nom2);
            }
            else // textBox1.Text != "Stephenie Meyer"
            {
                MessageBox.Show("iim zohiolch bhgui bn", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
