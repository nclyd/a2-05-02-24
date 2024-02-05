namespace Pod_Booking
{
    partial class Booking
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
            this.btnBookingReturn = new System.Windows.Forms.Button();
            this.btnBookingConfirm = new System.Windows.Forms.Button();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.dtpBookingStart = new System.Windows.Forms.DateTimePicker();
            this.dtpBookingEnd = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbForename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookingReturn
            // 
            this.btnBookingReturn.Location = new System.Drawing.Point(59, 561);
            this.btnBookingReturn.Name = "btnBookingReturn";
            this.btnBookingReturn.Size = new System.Drawing.Size(75, 30);
            this.btnBookingReturn.TabIndex = 20;
            this.btnBookingReturn.Text = "Return";
            this.btnBookingReturn.UseVisualStyleBackColor = true;
            // 
            // btnBookingConfirm
            // 
            this.btnBookingConfirm.Location = new System.Drawing.Point(366, 561);
            this.btnBookingConfirm.Name = "btnBookingConfirm";
            this.btnBookingConfirm.Size = new System.Drawing.Size(75, 30);
            this.btnBookingConfirm.TabIndex = 18;
            this.btnBookingConfirm.Text = "Confirm";
            this.btnBookingConfirm.UseVisualStyleBackColor = true;
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Location = new System.Drawing.Point(525, 133);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.RowHeadersWidth = 62;
            this.dgvBooking.RowTemplate.Height = 28;
            this.dgvBooking.Size = new System.Drawing.Size(734, 438);
            this.dgvBooking.TabIndex = 17;
            // 
            // dtpBookingStart
            // 
            this.dtpBookingStart.Location = new System.Drawing.Point(728, 87);
            this.dtpBookingStart.Name = "dtpBookingStart";
            this.dtpBookingStart.Size = new System.Drawing.Size(200, 26);
            this.dtpBookingStart.TabIndex = 16;
            // 
            // dtpBookingEnd
            // 
            this.dtpBookingEnd.Location = new System.Drawing.Point(977, 87);
            this.dtpBookingEnd.Name = "dtpBookingEnd";
            this.dtpBookingEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpBookingEnd.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 369);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 26);
            this.textBox4.TabIndex = 14;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(147, 289);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(278, 26);
            this.tb.TabIndex = 13;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(147, 206);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(278, 26);
            this.tbSurname.TabIndex = 12;
            // 
            // tbForename
            // 
            this.tbForename.Location = new System.Drawing.Point(147, 133);
            this.tbForename.Name = "tbForename";
            this.tbForename.Size = new System.Drawing.Size(278, 26);
            this.tbForename.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Forename:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "TelNo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Postcode:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(322, 28);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Previous Customer:";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBookingReturn);
            this.Controls.Add(this.btnBookingConfirm);
            this.Controls.Add(this.dgvBooking);
            this.Controls.Add(this.dtpBookingStart);
            this.Controls.Add(this.dtpBookingEnd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbForename);
            this.Name = "Booking";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookingReturn;
        private System.Windows.Forms.Button btnBookingConfirm;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DateTimePicker dtpBookingStart;
        private System.Windows.Forms.DateTimePicker dtpBookingEnd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbForename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

