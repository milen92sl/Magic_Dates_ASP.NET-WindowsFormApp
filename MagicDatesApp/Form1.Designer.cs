namespace MagicDatesApp
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_day = new System.Windows.Forms.Label();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_magic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chose a Date:";
            // 
            // lbl_day
            // 
            this.lbl_day.AutoSize = true;
            this.lbl_day.Location = new System.Drawing.Point(308, 38);
            this.lbl_day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day.Name = "lbl_day";
            this.lbl_day.Size = new System.Drawing.Size(37, 16);
            this.lbl_day.TabIndex = 2;
            this.lbl_day.Text = "Day:";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Location = new System.Drawing.Point(387, 38);
            this.lbl_month.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(57, 16);
            this.lbl_month.TabIndex = 3;
            this.lbl_month.Text = "Month:";
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Location = new System.Drawing.Point(463, 74);
            this.lbl_sum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(42, 16);
            this.lbl_sum.TabIndex = 4;
            this.lbl_sum.Text = "Sum:";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(463, 38);
            this.lbl_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(44, 16);
            this.lbl_year.TabIndex = 5;
            this.lbl_year.Text = "Year:";
            // 
            // lbl_magic
            // 
            this.lbl_magic.AutoSize = true;
            this.lbl_magic.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_magic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_magic.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_magic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_magic.Location = new System.Drawing.Point(247, 116);
            this.lbl_magic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_magic.Name = "lbl_magic";
            this.lbl_magic.Size = new System.Drawing.Size(223, 16);
            this.lbl_magic.TabIndex = 6;
            this.lbl_magic.Text = "See which date is magic date...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(621, 216);
            this.Controls.Add(this.lbl_magic);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_sum);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Magic Dates";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_day;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_magic;
    }
}

