
namespace Car_Class
{
    partial class carForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.speedLabel = new System.Windows.Forms.Label();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carMakeLabel = new System.Windows.Forms.Label();
            this.carYearTextBox = new System.Windows.Forms.TextBox();
            this.carMakeTextBox = new System.Windows.Forms.TextBox();
            this.accelerateButton = new System.Windows.Forms.Button();
            this.brakeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.beginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // speedLabel
            // 
            this.speedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(130, 241);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(125, 25);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "0 MPH";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carPictureBox
            // 
            this.carPictureBox.Image = global::Car_Class.Properties.Resources.cartoon_car;
            this.carPictureBox.Location = new System.Drawing.Point(102, 80);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(180, 140);
            this.carPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPictureBox.TabIndex = 1;
            this.carPictureBox.TabStop = false;
            // 
            // carYearLabel
            // 
            this.carYearLabel.Location = new System.Drawing.Point(9, 16);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(98, 20);
            this.carYearLabel.TabIndex = 2;
            this.carYearLabel.Text = "Year of Car:";
            this.carYearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carMakeLabel
            // 
            this.carMakeLabel.Location = new System.Drawing.Point(271, 16);
            this.carMakeLabel.Name = "carMakeLabel";
            this.carMakeLabel.Size = new System.Drawing.Size(98, 20);
            this.carMakeLabel.TabIndex = 3;
            this.carMakeLabel.Text = "Make of Car:";
            this.carMakeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Location = new System.Drawing.Point(12, 42);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.Size = new System.Drawing.Size(98, 20);
            this.carYearTextBox.TabIndex = 4;
            // 
            // carMakeTextBox
            // 
            this.carMakeTextBox.Location = new System.Drawing.Point(274, 42);
            this.carMakeTextBox.Name = "carMakeTextBox";
            this.carMakeTextBox.Size = new System.Drawing.Size(98, 20);
            this.carMakeTextBox.TabIndex = 5;
            // 
            // accelerateButton
            // 
            this.accelerateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.accelerateButton.Location = new System.Drawing.Point(3, 241);
            this.accelerateButton.Name = "accelerateButton";
            this.accelerateButton.Size = new System.Drawing.Size(100, 30);
            this.accelerateButton.TabIndex = 6;
            this.accelerateButton.Text = "Accelerate";
            this.accelerateButton.UseVisualStyleBackColor = true;
            this.accelerateButton.Click += new System.EventHandler(this.accelerateButton_Click);
            // 
            // brakeButton
            // 
            this.brakeButton.Location = new System.Drawing.Point(281, 241);
            this.brakeButton.Name = "brakeButton";
            this.brakeButton.Size = new System.Drawing.Size(100, 30);
            this.brakeButton.TabIndex = 7;
            this.brakeButton.Text = "Brake";
            this.brakeButton.UseVisualStyleBackColor = true;
            this.brakeButton.Click += new System.EventHandler(this.brakeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(102, 298);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(207, 298);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(153, 42);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(75, 23);
            this.beginButton.TabIndex = 10;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // carForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 336);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.brakeButton);
            this.Controls.Add(this.accelerateButton);
            this.Controls.Add(this.carMakeTextBox);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.carMakeLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.speedLabel);
            this.Name = "carForm";
            this.Text = "Car Class";
            this.Load += new System.EventHandler(this.carForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label carMakeLabel;
        private System.Windows.Forms.TextBox carYearTextBox;
        private System.Windows.Forms.TextBox carMakeTextBox;
        private System.Windows.Forms.Button accelerateButton;
        private System.Windows.Forms.Button brakeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button beginButton;
    }
}

