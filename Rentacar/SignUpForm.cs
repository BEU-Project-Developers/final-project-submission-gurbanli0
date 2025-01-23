using Rentacar.model.dto.request;
using Rentacar.service;

namespace Rentacar
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void GoToLoginForm()
        {
            Hide();
            var loginForm = new Form1();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.ShowDialog();
        }

        private void buttonSignUp_Click_1(object sender, EventArgs e)
        {
            CustomerService customerService = new();

            var name = textBoxName.Text;
            var username = textBoxUsername.Text;
            var password = textBoxPassword.Text;
            var confirmPassword = textBoxPassword.Text;

            var request = new CustomerCreateRequest
            {
                Name = name,
                Username = username,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            try
            {
                customerService.Create(request);
                MessageBox.Show(@"Account created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            GoToLoginForm();
        }
    }
}
