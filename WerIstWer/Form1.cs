using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerIstWer
{
    public partial class Form1 : Form
    {
        protected Data.Zoo zoo;
        public Form1()
        {
            InitializeComponent();

            zoo = new Data.Zoo();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewItemWindow niw = new NewItemWindow();
            DialogResult result = niw.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    zoo.AddNewItem(niw.GetNewItem());
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
