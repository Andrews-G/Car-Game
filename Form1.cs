/************************************************************************
 * Car Class
 * Grant Andrews
 * 7/24/2022
 * This program allows the user to enter a vehicles make and year,
 * the user can then use the accelarate and brake buttons to change 
 * the speed of the car, the brake cannot be used when speed == 0.
 * The user can reset the Form to start over. A Car class is created
 * and referenced to keep track of the car's speed.
 *///////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Class
{
    public partial class carForm : Form
    {
        public carForm()
        {
            InitializeComponent();
        }

        // Create an object of the Car class
        private Car yourCar = new Car();

        private void beginButton_Click(object sender, EventArgs e)
        // This event handler ensures that valid data has been entered by calling
        // the DataCheck method
        {
            if (DataCheck())
            {
                Car yourCar = new Car();
                yourCar.Year = (int.Parse(carYearTextBox.Text));
                yourCar.Make = carMakeTextBox.Text;
                accelerateButton.Enabled = true;
                brakeButton.Enabled = false;
                resetButton.Enabled = true;
                beginButton.Enabled = false;
                carYearTextBox.Enabled = false;
                carMakeTextBox.Enabled = false;
            }
        }


        private void accelerateButton_Click(object sender, EventArgs e)
            // This event handler calls the Accelerate method
        {
            Accelerate();

        }


        private void brakeButton_Click(object sender, EventArgs e)
            // This event handler calls the Brake method
        {
            Brake();
        }


        private void resetButton_Click(object sender, EventArgs e)
            // This event handler calls the ResetAll method
        {
            ResetAll();
        }


        private void exitButton_Click(object sender, EventArgs e)
            // This event handler closes the Form
        {
            this.Close();
        }


        private bool DataCheck()
            // This method ensures that valid data has been entered
            // If not, inform the user with a MessageBox
        {
            // Declare and Initialize variable
            bool goodData = true;

            // Ensure data has been entered in both TextBoxes
            if (carYearTextBox.Text == "" || carMakeTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Vehicle's Year & Make.");
                goodData = false;
            }
            else if ((!int.TryParse(carYearTextBox.Text, out int goodNumber)))
            {
                MessageBox.Show("Please Enter a Valid Vehicle Year, Whole Numbers Only.");
                goodData = false;
            }

            return goodData;
        }

        private void Accelerate()
            // This method increments the Speed property of yourCar, displays this to the user,
            // changes the Form BackColor, and ensures that the brakeButton is enabled
        {
            yourCar.Speed += 5;
            speedLabel.Text = yourCar.Speed.ToString() + " MPH";
            this.BackColor = Color.Green;
            brakeButton.Enabled = true;
        }

        private void Brake()
            // This method decrements the Speed property of yourCar, displays this to the user,
            // and changes the Form BackColor. If the Speed property of yourCar == 0, reset the
            // Form BackColor to white, and disable the brakeButton
        {
            yourCar.Speed -= 5;
            speedLabel.Text = yourCar.Speed.ToString() + " MPH";
            this.BackColor = Color.Red;

            if (yourCar.Speed == 0)
            {
                brakeButton.Enabled = false;
                this.BackColor = Color.White;
            }
        }

        private void ResetAll()
            // This method resets the from so that the user must enter a year and make again. It disables
            // the brake and accelerate buttons and sets the Form BackColor to white, it enables the
            // beginButton, and resets the Speed property of yourCar to 0
        {
            speedLabel.Text = "O MPH";
            yourCar.Speed = 0;
            carYearTextBox.Text = "";
            carMakeTextBox.Text = "";
            this.BackColor = Color.White;
            carYearTextBox.Enabled = true;
            carMakeTextBox.Enabled = true;
            beginButton.Enabled = true;
            accelerateButton.Enabled = false;
            brakeButton.Enabled = false;
        }

        private void carForm_Load(object sender, EventArgs e)
            // This event handler disables the brake, accelerate, and begin buttons when the Form loads
        {
            accelerateButton.Enabled = false;
            brakeButton.Enabled = false;
            resetButton.Enabled = false;
        }
    }

}
