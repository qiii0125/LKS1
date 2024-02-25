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
    public partial class MainForm : Form
    {
        EsemkaLaundryDBDataContext db;
        private Employee _employee;
        public int employee_id { get; set; }
        public MainForm(int? emplyee_id)
        {
            InitializeComponent();
            db = new EsemkaLaundryDBDataContext();
            //_employee = (from Employee in  db.Employees where Employee.Id == employee_id select Employee).First();
            //greeting.Text = $"Welcome, {_employee.Name}";
            //time.Text = DateTime.Now.ToString("F");
            /*_employee = db.Employees.FirstOrDefault(_employee => _employee.Id == employee_id);
            if (_employee == null)
            {
                MessageBox.Show("Maaf Employee tidak ditemukan");
            }
            else
            {
                greeting.Text = $"Welcome, {_employee.Name}";
            }
            timer1.Start();*/
            // Pastikan ID Karyawan yang Diberikan adalah Valid
            /*if (employee_id == 0)
            {
                MessageBox.Show("Please select a valid Employee ID.");
                // Di sini Anda bisa menangani logika tambahan, misalnya:
                // - Meminta pengguna untuk memilih karyawan
                // - Menampilkan daftar karyawan untuk dipilih
                // - Atau melakukan tindakan lain sesuai dengan kebutuhan aplikasi Anda
            }
            Console.WriteLine($"Employee ID: {employee_id}");

            // Periksa Koneksi ke Basis Data
            try
            {
                db.Connection.Open();
                if (db.Connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Connection to database successful");
                }
                else
                {
                    Console.WriteLine("Connection to database failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to database: {ex.Message}");
            }
            finally
            {
                db.Connection.Close();
            }*/

            // Periksa Data Karyawan dalam Basis Data
            _employee = db.Employees.FirstOrDefault(Employee => Employee != null && Employee.Id == employee_id);
            if (_employee == null)
            {
                MessageBox.Show("Maaf Employee tidak ditemukan");
            Console.WriteLine($"Employee ID: {employee_id}");
            }
            else
            {
                greeting.Text = $"Welcome, {_employee.Name}";
            }

            timer1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            time.Text = DateTime.Now.ToString("F");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int? employee_id = null;
            EmployeeForm employeeForm = new EmployeeForm(employee_id);
            this.Hide();
            employeeForm.ShowDialog();
        }

        private void managePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PackageForm packageForm = new PackageForm();
            this.Hide();
            packageForm.ShowDialog();
        }

        private void manageServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            this.Hide();
            serviceForm.ShowDialog();
        }

        private void transactionDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionDepositForm transactionDepositForm = new TransactionDepositForm();
            this.Hide();
            transactionDepositForm.ShowDialog();
        }

        private void prepaidPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionPrepaidPackageForm transactionPrepaidPackageForm = new TransactionPrepaidPackageForm();
            this.Hide();
            transactionPrepaidPackageForm.ShowDialog();
        }

        private void viewTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ViewTransactionForm viewTransactionForm = new ViewTransactionForm();
            this.Hide();
            viewTransactionForm.ShowDialog();
        }
    }
}
