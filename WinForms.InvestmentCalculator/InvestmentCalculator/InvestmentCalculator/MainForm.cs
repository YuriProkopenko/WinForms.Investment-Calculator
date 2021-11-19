using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Investment;

namespace InvestmentCalculator
{
    public partial class MainForm : Form
    {
        double loanBody;
        double annualRate;
        int creditTerm;
        DateTime paymentDate;
        List<Payment> payments = new List<Payment>();

        public MainForm()
        {
            InitializeComponent();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
        private void button_annuity_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
                loanBody = Convert.ToDouble(textBox_loanBody.Text);
                annualRate = Convert.ToDouble(textBox_annualRate.Text);
                creditTerm = Convert.ToInt32(textBox_creditTerm.Text);
                paymentDate = dateTimePicker_paymentDate.Value.Date;
                payments = AnnuitySchedule.Payments(loanBody, annualRate, creditTerm, paymentDate);
                int number = 0;
                double investmentCost = 0;
                foreach (var payment in payments)
                {
                    string[] paymentArr = {Convert.ToString(++number),
                                           Convert.ToString(payment.NextPaymentDate),
                                           Convert.ToString(payment.BalanceOwed),
                                           Convert.ToString(payment.MontlyPayment),
                                           Convert.ToString(payment.PercentPart),
                                           Convert.ToString(payment.DebtPart),
                                           Convert.ToString(payment.BalanceOwedAfter)};
                    dataGridView.Rows.Add(paymentArr);
                    investmentCost += payment.MontlyPayment;
                }
                label_result.Text = $"Investment cost : {Math.Round(investmentCost, 2)}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_differential_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.Clear();
                loanBody = Convert.ToDouble(textBox_loanBody.Text);
                annualRate = Convert.ToDouble(textBox_annualRate.Text);
                creditTerm = Convert.ToInt32(textBox_creditTerm.Text);
                paymentDate = dateTimePicker_paymentDate.Value.Date;
                payments = DifferentialSchedule.Payments(loanBody, annualRate, creditTerm, paymentDate);
                int number = 0;
                double investmentCost = 0;
                foreach (var payment in payments)
                {
                    string[] paymentArr = {Convert.ToString(++number),
                                           Convert.ToString(payment.NextPaymentDate),
                                           Convert.ToString(payment.BalanceOwed),
                                           Convert.ToString(payment.MontlyPayment),
                                           Convert.ToString(payment.PercentPart),
                                           Convert.ToString(payment.DebtPart),
                                           Convert.ToString(payment.BalanceOwedAfter)};
                    dataGridView.Rows.Add(paymentArr);
                    investmentCost += payment.MontlyPayment;
                }
                label_result.Text = $"Investment cost : {Math.Round(investmentCost, 2)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
