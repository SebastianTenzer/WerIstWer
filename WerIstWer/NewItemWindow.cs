using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WerIstWer
{
    public partial class NewItemWindow : Form
    {
        Data.Animal newAnimal;

        public NewItemWindow()
        {
            InitializeComponent();

            newAnimal = new Data.Animal();
            button_Cancel.DialogResult = DialogResult.Cancel;
        }

        public Data.Animal GetNewItem()
        {
            return newAnimal;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            newAnimal.FirstName = textBox_Firstname.Text;
            newAnimal.LastName  = textBox_Lastname.Text;

            this.DialogResult = DialogResult.OK;

        }
    }
}
