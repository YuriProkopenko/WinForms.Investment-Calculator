using System;
using System.Collections.Generic;

namespace Investment
{
    public static class DifferentialSchedule
    {
        public static List<Payment> Payments(double loanBody, double annualRate, int creditTerm, DateTime dateOfPayment)
        {
            double interestRateMonth = Calculate_InterestRateMonth(annualRate);
            double debtPart = Calculate_DebtPart(loanBody, creditTerm);
            Payment payment = new Payment();
            List<Payment> payments = new List<Payment>();
            for (int i = 0; i < creditTerm; i++)
            {
                payment.NextPaymentDate = dateOfPayment;
                dateOfPayment = dateOfPayment.AddMonths(1);
                payment.DebtPart = Math.Round(debtPart, 2);
                double percentPart = Calculate_PercentPart(loanBody, interestRateMonth);
                payment.PercentPart = Math.Round(percentPart, 2);
                double monthlyPayment = Calculate_MonthlyPayment(debtPart, percentPart);
                payment.MontlyPayment = Math.Round(monthlyPayment, 2);
                payment.BalanceOwed = Math.Round(loanBody, 2);
                loanBody -= debtPart;
                payment.BalanceOwedAfter = Math.Round(loanBody, 2);
                payments.Add(payment);
            }
            return payments;
        }
        private static double Calculate_InterestRateMonth(double annualRate) =>
            annualRate / 100.0 / 12.0;
        private static double Calculate_MonthlyPayment(double debtPart, double percentPart) =>
            debtPart + percentPart;
        private static double Calculate_PercentPart(double loanBody, double interestRateMonth) =>
            loanBody * interestRateMonth;
        private static double Calculate_DebtPart(double loanBody, int creditTerm) =>
            loanBody / creditTerm;
    }
}
