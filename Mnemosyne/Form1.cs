using System.Windows.Forms;
using help_about;

namespace Mnemosyne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbobx_pinyin.SelectedIndex = 0;
            cmbobx_zhu.SelectedIndex = 0;
            cmbobx_zhu_real.SelectedIndex = 0;
            cmbobx_romaji.SelectedIndex = 0;

        }

        void close()
        {
            this.Close();
        }

       

        private void btn_help_1_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void btn_help_2_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void btn_help_4_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void btn_help_3_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void btn_help_5_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void btn_help_6_Click(object sender, System.EventArgs e)
        {
            help();
        }

        private void help()
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
        }
    }
}
