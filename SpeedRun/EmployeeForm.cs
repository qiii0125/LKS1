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
    public partial class EmployeeForm : Form
    {
        EsemkaLaundryDBDataContext db;
        public Employee _employee;
        public EmployeeForm(int? employee_id)
        {
            InitializeComponent();
            db = new EsemkaLaundryDBDataContext();
        }

        public EmployeeForm()
        {
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from Employee in db.Employees join Job in db.Jobs on Employee.IdJob equals Job.Id orderby Employee.Id select new
            {
                Employee.Id,
                Employee.Name,
                Employee.Email,
                Employee.PhoneNumber,
                Employee.Address,
                Employee.DateofBirth,
                JobName = Job.Name,
                Employee.Salary,
                Employee.Password
            }).ToList();
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id.Text = row.Cells["Id"].Value.ToString();
            name.Text = row.Cells["Name"].Value.ToString();
            email.Text = row.Cells["Email"].Value.ToString();
            PhoneNum.Text = row.Cells["PhoneNumber"].Value.ToString();
            address.Text = row.Cells["Address"].Value.ToString();
            jobTitle.Text = row.Cells["JobName"].Value.ToString();
            pass.Text = row.Cells["Password"].ToString();
            object salary = row.Cells["Salary"].Value;
            if (salary != null)
            {
                salary = salary.ToString();
            }
            object dobvalue = row.Cells["DateOfBirth"].Value;
            if (dobvalue != null)
            {
                dob.Value = (DateTime)dobvalue;
            }
            else
            {
                dob.Value = DateTime.Now;
            }
        }
    }
}
