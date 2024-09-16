/*
* Class name : Loan
* Class description : Static class with static method to return monthly payment.
* Developer name : Sai Kranth Koneru
* Date created : 09 / 13 / 2024
* Date modified : 09 / 15 / 2024
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Program_4
{
    public static class Loan
    {
        //Static method takes the parameters as loanAmount,loanTerm in months ,annualInterstRate 
        public static double CalculateMonthlyPayment(double loanAmount,int loanTerm,double annualInterestRate)
        {
            double monthlyInterestRate = annualInterestRate / (100 * 12);
            double monthlyPayment = loanAmount * (monthlyInterestRate * (double)Math.Pow((double)(1 + monthlyInterestRate), loanTerm)) / ((double)Math.Pow((double)(1 + monthlyInterestRate), loanTerm) - 1);

            return monthlyPayment;
        }
    }
}
