using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurkishtoLatex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "TURKISH";
            label2.Text = "LaTeX";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string realString = richTextBox1.Text;
            string convertText = turkishToLatex(realString);
            richTextBox2.Text = convertText;
        }

        public string turkishToLatex(string text)
        {
            return text.Replace("\u011E", "\\u{G}").
                Replace("\u011F", "\\u{g}").
                Replace("\u00DC", "\\\"U").
                Replace("\u00FC", "\\\"u").
                Replace("\u00C7", "\\c{C}").
                Replace("\u00E7", "\\c{c}").
                Replace("\u015E", "\\c{S}").
                Replace("\u015F", "\\c{s}").
                Replace("\u00D6", "\\\"O").
                Replace("\u00F6", "\\\"o").
                Replace("\u0131", "{\\i}").
                Replace("\u0130", "\\.{I}").
                Replace("\u00E2", "\\^{a}").
                Replace("\u00FB", "\\^{u}").
                Replace("\u00EE", "\\^{i}").
                Replace("\u00C2", "\\^{A}").
                Replace("\u00DB", "\\^{U}").
                Replace("\u00CE", "\\^{I}").
                Replace("%", "\\%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
            MessageBox.Show("Yazı kopyalandı.");
        }
    }
}
