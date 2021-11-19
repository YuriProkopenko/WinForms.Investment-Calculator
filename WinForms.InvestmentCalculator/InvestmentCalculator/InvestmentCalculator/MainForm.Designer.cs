
namespace InvestmentCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_loanBody = new System.Windows.Forms.Label();
            this.textBox_loanBody = new System.Windows.Forms.TextBox();
            this.label_annualRate = new System.Windows.Forms.Label();
            this.textBox_annualRate = new System.Windows.Forms.TextBox();
            this.label_creditTerm = new System.Windows.Forms.Label();
            this.textBox_creditTerm = new System.Windows.Forms.TextBox();
            this.label_paymentDate = new System.Windows.Forms.Label();
            this.button_annuity = new System.Windows.Forms.Button();
            this.button_differential = new System.Windows.Forms.Button();
            this.dateTimePicker_paymentDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_result = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_loanBody
            // 
            this.label_loanBody.AutoSize = true;
            this.label_loanBody.Location = new System.Drawing.Point(31, 19);
            this.label_loanBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loanBody.Name = "label_loanBody";
            this.label_loanBody.Size = new System.Drawing.Size(81, 18);
            this.label_loanBody.TabIndex = 0;
            this.label_loanBody.Text = "Loan body";
            // 
            // textBox_loanBody
            // 
            this.textBox_loanBody.Location = new System.Drawing.Point(149, 16);
            this.textBox_loanBody.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_loanBody.Name = "textBox_loanBody";
            this.textBox_loanBody.Size = new System.Drawing.Size(126, 26);
            this.textBox_loanBody.TabIndex = 1;
            this.textBox_loanBody.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_annualRate
            // 
            this.label_annualRate.AutoSize = true;
            this.label_annualRate.Location = new System.Drawing.Point(31, 54);
            this.label_annualRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_annualRate.Name = "label_annualRate";
            this.label_annualRate.Size = new System.Drawing.Size(86, 18);
            this.label_annualRate.TabIndex = 0;
            this.label_annualRate.Text = "Annual rate";
            // 
            // textBox_annualRate
            // 
            this.textBox_annualRate.Location = new System.Drawing.Point(149, 50);
            this.textBox_annualRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_annualRate.Name = "textBox_annualRate";
            this.textBox_annualRate.Size = new System.Drawing.Size(126, 26);
            this.textBox_annualRate.TabIndex = 2;
            this.textBox_annualRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_creditTerm
            // 
            this.label_creditTerm.AutoSize = true;
            this.label_creditTerm.Location = new System.Drawing.Point(31, 89);
            this.label_creditTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_creditTerm.Name = "label_creditTerm";
            this.label_creditTerm.Size = new System.Drawing.Size(86, 18);
            this.label_creditTerm.TabIndex = 0;
            this.label_creditTerm.Text = "Credit term";
            // 
            // textBox_creditTerm
            // 
            this.textBox_creditTerm.Location = new System.Drawing.Point(149, 84);
            this.textBox_creditTerm.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_creditTerm.Name = "textBox_creditTerm";
            this.textBox_creditTerm.Size = new System.Drawing.Size(126, 26);
            this.textBox_creditTerm.TabIndex = 3;
            this.textBox_creditTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label_paymentDate
            // 
            this.label_paymentDate.AutoSize = true;
            this.label_paymentDate.Location = new System.Drawing.Point(31, 124);
            this.label_paymentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_paymentDate.Name = "label_paymentDate";
            this.label_paymentDate.Size = new System.Drawing.Size(104, 18);
            this.label_paymentDate.TabIndex = 0;
            this.label_paymentDate.Text = "Payment date";
            // 
            // button_annuity
            // 
            this.button_annuity.Location = new System.Drawing.Point(608, 89);
            this.button_annuity.Margin = new System.Windows.Forms.Padding(4);
            this.button_annuity.Name = "button_annuity";
            this.button_annuity.Size = new System.Drawing.Size(162, 60);
            this.button_annuity.TabIndex = 5;
            this.button_annuity.Text = "Annuity schedule";
            this.button_annuity.UseVisualStyleBackColor = true;
            this.button_annuity.Click += new System.EventHandler(this.button_annuity_Click);
            // 
            // button_differential
            // 
            this.button_differential.Location = new System.Drawing.Point(827, 89);
            this.button_differential.Margin = new System.Windows.Forms.Padding(4);
            this.button_differential.Name = "button_differential";
            this.button_differential.Size = new System.Drawing.Size(162, 60);
            this.button_differential.TabIndex = 6;
            this.button_differential.Text = "Differential schedule";
            this.button_differential.UseVisualStyleBackColor = true;
            this.button_differential.Click += new System.EventHandler(this.button_differential_Click);
            // 
            // dateTimePicker_paymentDate
            // 
            this.dateTimePicker_paymentDate.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker_paymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_paymentDate.Location = new System.Drawing.Point(149, 116);
            this.dateTimePicker_paymentDate.Name = "dateTimePicker_paymentDate";
            this.dateTimePicker_paymentDate.Size = new System.Drawing.Size(126, 26);
            this.dateTimePicker_paymentDate.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(31, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 341);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(958, 341);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "№";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 140F;
            this.Column2.HeaderText = "Payment date";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 170F;
            this.Column3.HeaderText = "Balance owed";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 172;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 140F;
            this.Column4.HeaderText = "Monthly payment";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 140F;
            this.Column5.HeaderText = "Percent part";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 140F;
            this.Column6.HeaderText = "Debt part";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 140;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 170F;
            this.Column7.HeaderText = "Balance owed after";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 172;
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_result.Location = new System.Drawing.Point(301, 19);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 24);
            this.label_result.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 540);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_paymentDate);
            this.Controls.Add(this.button_differential);
            this.Controls.Add(this.button_annuity);
            this.Controls.Add(this.textBox_creditTerm);
            this.Controls.Add(this.textBox_annualRate);
            this.Controls.Add(this.textBox_loanBody);
            this.Controls.Add(this.label_paymentDate);
            this.Controls.Add(this.label_creditTerm);
            this.Controls.Add(this.label_annualRate);
            this.Controls.Add(this.label_loanBody);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Investment Calculator";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loanBody;
        private System.Windows.Forms.TextBox textBox_loanBody;
        private System.Windows.Forms.Label label_annualRate;
        private System.Windows.Forms.TextBox textBox_annualRate;
        private System.Windows.Forms.Label label_creditTerm;
        private System.Windows.Forms.TextBox textBox_creditTerm;
        private System.Windows.Forms.Label label_paymentDate;
        private System.Windows.Forms.Button button_annuity;
        private System.Windows.Forms.Button button_differential;
        private System.Windows.Forms.DateTimePicker dateTimePicker_paymentDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label_result;
    }
}

