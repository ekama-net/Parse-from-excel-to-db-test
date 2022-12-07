using System;
using System.Linq;
using System.Windows.Forms;

namespace AlgimedTask
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                var data = context.Users.ToList();
                if (textBox1.Text == data.First(i => i.Id == 1).Pass)
                {
                    Hide();
                    mainForm form = new mainForm();
                    form.ShowDialog();
                    Close();
                }
                else MessageBox.Show("Wrong password");
            }
        }
    }
}
