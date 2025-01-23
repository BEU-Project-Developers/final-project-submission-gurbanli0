using Rentacar.model.dto.request;
using Rentacar.service;
using static Rentacar.FormsHelper;

namespace Rentacar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSignUp1_Click(object sender, EventArgs e)
        {
            Hide();
            var signUpForm = new SignUpForm();
            signUpForm.FormClosed += (s, args) => Close();
            signUpForm.ShowDialog();
        }

        private void buttonLogin1_Click(object sender, EventArgs e)
        {
            CustomerService passengerService = new();

            var request = new CustomerLoginRequest
            {
                Username = textBoxUser.Text,
                Password = textBoxPass.Text
            };

            try
            {
                CURRENT_CUSTOMER = passengerService.Login(request);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            Hide();
            var mainForm = new Main();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.ShowDialog();
        }
    }
}
