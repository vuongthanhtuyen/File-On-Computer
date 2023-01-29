namespace Lich
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
            this.flpLich = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flpDay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpLich
            // 
            this.flpLich.Location = new System.Drawing.Point(25, 141);
            this.flpLich.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flpLich.Name = "flpLich";
            this.flpLich.Size = new System.Drawing.Size(462, 415);
            this.flpLich.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(576, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 34);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // flpDay
            // 
            this.flpDay.Location = new System.Drawing.Point(25, 98);
            this.flpDay.Name = "flpDay";
            this.flpDay.Size = new System.Drawing.Size(462, 35);
            this.flpDay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 613);
            this.Controls.Add(this.flpDay);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.flpLich);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLich;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flpDay;
    }
}

