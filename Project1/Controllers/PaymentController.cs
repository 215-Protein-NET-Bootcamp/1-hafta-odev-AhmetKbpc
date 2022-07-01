using Microsoft.AspNetCore.Mvc;
using Project1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hafta1_Proje1.Controllers
{

    [Route("api/Payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        [HttpGet]
        [Route("Amounts")]
        public List<Amounts> Amounts(double capital, int date)
        {
            double interestRate = 0.05;
            double total = capital * (1 + (interestRate*date));
            double interest = capital * (1 + (interestRate * date)) - capital;
            double monthly = capital * (1 + interestRate) / date;

            var result = Enumerable.Range(1, 1).Select(index => new Amounts
            {
              PaymentAmount= Math.Round(total, 3),
              InterestAmount= Math.Round(interest, 3)

            }).ToList();

            return result;
        }


        [HttpGet]
        [Route("MonthlyPlan")]
        public List<MonthlyPayment> MonthlyPlan(double capital, int date )
        {
            double interestRate = 0.05;
            double total = capital * (1 + (interestRate * date));
            double interest = capital * (1 + (interestRate * date)) - capital;
            double monthly = capital * (1 + interestRate) / date;

            var result = Enumerable.Range(1, date).Select(index => new MonthlyPayment
            {
                Month = index,
                MonthlyPrice = Math.Round(monthly, 2)

            }).ToList();


            return result;
        }


    }
}

