using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms;

namespace AlgimedTask
{
    public partial class DbOutputForm : Form
    {
        public DbOutputForm(Result[] res)
        {
            InitializeComponent();
            using (var context = new Context())
            {
                var results = context.Database.ExecuteSqlRaw("Delete From Results");
                context.Results.AddRange(res);
                context.SaveChanges();

                var data = context.Results.ToList();
                dataGridView1.DataSource = data;
                dataGridView1.Columns["Id"].Visible = false;
            }
        }
    }
}
