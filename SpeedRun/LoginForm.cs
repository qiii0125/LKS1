using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedRun
{
    public partial class LoginForm : Form
    {
        EsemkaLaundryDBDataContext db;
        public int? employee_id { get; set; } 
        public LoginForm()
        {
            InitializeComponent();
            db = new EsemkaLaundryDBDataContext();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void toPass(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                textBox2.Focus();
            }
        }

        private void Submit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                loginBtn_Click(sender, e);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var q = 
                from Employee in db.Employees 
                where Employee != null && Employee.Email == textBox1.Text && Employee.Password == textBox2.Text
                select Employee;
            Employee employee = q.FirstOrDefault();
            if (employee != null)
            {
                employee_id = (int)employee.Id;
                this.Hide();
                MainForm form = new MainForm(employee_id);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("benerin anying");
            }
        }
    }
}
