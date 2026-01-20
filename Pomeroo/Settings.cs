using Pomeroo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomeroo
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string[] formats = { "mm\\:ss", "hh\\:mm\\:ss" };

            // assign new values to model
            if (TimeSpan.TryParseExact(txtWorkTime.Text, formats, CultureInfo.InvariantCulture, out TimeSpan workTime) &&
               TimeSpan.TryParseExact(txtShortRest.Text, formats, CultureInfo.InvariantCulture, out TimeSpan shortRest) &&
               TimeSpan.TryParseExact(txtLongRest.Text, formats, CultureInfo.InvariantCulture, out TimeSpan longRest) &&
               int.TryParse(txtCycleCount.Text, out int cycleCount))
            {
                // assign new values to model
                TimerModel.workTime = (int)workTime.TotalSeconds;
                TimerModel.shortRest = (int)shortRest.TotalSeconds;
                TimerModel.longRest = (int)longRest.TotalSeconds;
                TimerModel.cycleCount = cycleCount;
            }
            else
            {
                MessageBox.Show("Please enter valid values for all fields.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // close window
            this.DialogResult = DialogResult.OK;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtWorkTime.Text = TimeSpan.FromSeconds(TimerModel.workTime).ToString(@"mm\:ss");
            txtShortRest.Text = TimeSpan.FromSeconds(TimerModel.shortRest).ToString(@"mm\:ss");
            txtLongRest.Text = TimeSpan.FromSeconds(TimerModel.longRest).ToString(@"mm\:ss");
            txtCycleCount.Text = TimerModel.cycleCount.ToString();
        }
    }
}
