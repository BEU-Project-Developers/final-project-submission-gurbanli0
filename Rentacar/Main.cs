using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentacar.model.dto.request;
using Rentacar.service;
using static Rentacar.FormsHelper;

namespace Rentacar
{
    public partial class Main : Form
    {
        private readonly CarService _carService = new();
        private readonly BookingService _bookingService = new();
        public Main()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowInfoForm(_carService.ShowAvailableCarsIn24Hours());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var carSearchRequest = new CarSearchRequest
            (
                comboBox1.Text,
                comboBox2.Text,
                DateOnly.FromDateTime(dateTimePicker1.Value),
                (int)numericUpDown1.Value
            );
            ShowInfoForm(_carService.SearchCars(carSearchRequest, checkBox1.Checked));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _bookingService.UpdateCarBookingsStatus();
            ShowInfoForm(_bookingService.ShowMyCarBookings());
        }
    }
}
