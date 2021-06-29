namespace Phase_2_Database
{
    partial class Form1
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
            this.AirPlane = new System.Windows.Forms.DataGridView();
            this.AirPort = new System.Windows.Forms.DataGridView();
            this.AirLine = new System.Windows.Forms.DataGridView();
            this.Flight = new System.Windows.Forms.DataGridView();
            this.btn_airport = new System.Windows.Forms.Button();
            this.btn_flight = new System.Windows.Forms.Button();
            this.btn_airline = new System.Windows.Forms.Button();
            this.btn_airplane = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AirPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flight)).BeginInit();
            this.SuspendLayout();
            // 
            // AirPlane
            // 
            this.AirPlane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AirPlane.Location = new System.Drawing.Point(12, 31);
            this.AirPlane.Name = "AirPlane";
            this.AirPlane.Size = new System.Drawing.Size(393, 191);
            this.AirPlane.TabIndex = 0;
            this.AirPlane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirPlane_CellContentClick);
            // 
            // AirPort
            // 
            this.AirPort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AirPort.Location = new System.Drawing.Point(12, 255);
            this.AirPort.Name = "AirPort";
            this.AirPort.Size = new System.Drawing.Size(393, 167);
            this.AirPort.TabIndex = 1;
            this.AirPort.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirPort_CellContentClick);
            // 
            // AirLine
            // 
            this.AirLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AirLine.Location = new System.Drawing.Point(411, 31);
            this.AirLine.Name = "AirLine";
            this.AirLine.Size = new System.Drawing.Size(377, 191);
            this.AirLine.TabIndex = 2;
            this.AirLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AirLine_CellContentClick);
            // 
            // Flight
            // 
            this.Flight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Flight.Location = new System.Drawing.Point(411, 255);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(377, 167);
            this.Flight.TabIndex = 3;
            this.Flight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Flight_CellContentClick);
            // 
            // btn_airport
            // 
            this.btn_airport.Location = new System.Drawing.Point(156, 226);
            this.btn_airport.Name = "btn_airport";
            this.btn_airport.Size = new System.Drawing.Size(75, 23);
            this.btn_airport.TabIndex = 6;
            this.btn_airport.Text = "AirPort";
            this.btn_airport.UseVisualStyleBackColor = true;
            this.btn_airport.Click += new System.EventHandler(this.btn_airport_Click);
            // 
            // btn_flight
            // 
            this.btn_flight.Location = new System.Drawing.Point(566, 226);
            this.btn_flight.Name = "btn_flight";
            this.btn_flight.Size = new System.Drawing.Size(75, 23);
            this.btn_flight.TabIndex = 7;
            this.btn_flight.Text = "Flight";
            this.btn_flight.UseVisualStyleBackColor = true;
            this.btn_flight.Click += new System.EventHandler(this.btn_flight_Click);
            // 
            // btn_airline
            // 
            this.btn_airline.Location = new System.Drawing.Point(566, 2);
            this.btn_airline.Name = "btn_airline";
            this.btn_airline.Size = new System.Drawing.Size(75, 23);
            this.btn_airline.TabIndex = 5;
            this.btn_airline.Text = "AirLine";
            this.btn_airline.UseVisualStyleBackColor = true;
            this.btn_airline.Click += new System.EventHandler(this.btn_airline_Click);
            // 
            // btn_airplane
            // 
            this.btn_airplane.Location = new System.Drawing.Point(156, 2);
            this.btn_airplane.Name = "btn_airplane";
            this.btn_airplane.Size = new System.Drawing.Size(75, 23);
            this.btn_airplane.TabIndex = 4;
            this.btn_airplane.Text = "AirPlane";
            this.btn_airplane.UseVisualStyleBackColor = true;
            this.btn_airplane.Click += new System.EventHandler(this.btn_airplane_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(370, 428);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_flight);
            this.Controls.Add(this.btn_airport);
            this.Controls.Add(this.btn_airline);
            this.Controls.Add(this.btn_airplane);
            this.Controls.Add(this.Flight);
            this.Controls.Add(this.AirLine);
            this.Controls.Add(this.AirPort);
            this.Controls.Add(this.AirPlane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AirPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AirPlane;
        private System.Windows.Forms.DataGridView AirPort;
        private System.Windows.Forms.DataGridView AirLine;
        private System.Windows.Forms.DataGridView Flight;
        private System.Windows.Forms.Button btn_airport;
        private System.Windows.Forms.Button btn_flight;
        private System.Windows.Forms.Button btn_airline;
        private System.Windows.Forms.Button btn_airplane;
        private System.Windows.Forms.Button btn_save;
    }
}

