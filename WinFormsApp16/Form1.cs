using System.IO.MemoryMappedFiles;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elektrikliotomobil audiElektrikliOto = new elektrikliotomobil(124, "mavi", "�elik" );
            richTextBox1.Text = audiElektrikliOto.sarjdurumugetir() + "\nRenk: " + audiElektrikliOto.Renk + "\nCant: " + audiElektrikliOto.Cant;

            benzinliotomobil audiBenzinliOto = new benzinliotomobil(50, "k�rm�z�", "normal");
            richTextBox1.Text = richTextBox1.Text + "\n\n" + audiBenzinliOto.yak�tdurumugoster() + "\nRenk: " + audiBenzinliOto.Renk + "\nCant: " + audiBenzinliOto.Cant + "\nEn: " + audiBenzinliOto.getEn();






        }
    }
}