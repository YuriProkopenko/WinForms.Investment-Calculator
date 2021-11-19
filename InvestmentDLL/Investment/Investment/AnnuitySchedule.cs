using System;
using System.Collections.Generic;

namespace Investment
{
    public struct Payment
    {
        public DateTime NextPaymentDate { get; set; }
        public double MontlyPayment { get; set; }
        public double BalanceOwed { get; set; }
        public double PercentPart { get; set; }
        public double DebtPart { get; set; }
        public double BalanceOwedAfter { get; set; }
    }
    public static class AnnuitySchedule
    {
        public static List<Payment> Payments(double loanBody, double annualRate, int creditTerm, DateTime dateOfPayment)
        {
            double interestRateMonth = Calculate_InterestRateMonth(annualRate);
            double monthlyPayment = Calculate_MonthlyPayment(loanBody, annualRate, creditTerm, interestRateMonth);
            Payment payment = new Payment();
            List<Payment> payments = new List<Payment>();
            for (int i = 0; i < creditTerm; i++)
            {
                payment.NextPaymentDate = dateOfPayment;
                dateOfPayment = dateOfPayment.AddMonths(1);
                payment.MontlyPayment = Math.Round(monthlyPayment, 2);
                double percentPart = Math.Round(Calculate_PercentPart(loanBody, interestRateMonth), 2);
                payment.PercentPart = percentPart;
                double debtPart = Math.Round(Calculate_DebtPart(monthlyPayment, percentPart), 2);
                payment.DebtPart = debtPart;
                payment.BalanceOwed = Math.Round(loanBody, 2);
                loanBody -= debtPart;
                payment.BalanceOwedAfter = Math.Round(loanBody, 2);
                payments.Add(payment);
            }
            return payments;
        }
        private static double Calculate_InterestRateMonth(double annualRate) =>
            annualRate / 100.0 / 12.0;
        private static double Calculate_MonthlyPayment(double loanBody, double annualRate, int creditTerm, double interestRateMonth) =>
            loanBody * (interestRateMonth + (interestRateMonth / (Math.Pow(1 + interestRateMonth, creditTerm) - 1)));
        private static double Calculate_PercentPart(double loanBody, double interestRateMonth) =>
            loanBody * interestRateMonth;
        private static double Calculate_DebtPart(double monthlyPayment, double percentPart) =>
            monthlyPayment - percentPart;
    }
}
