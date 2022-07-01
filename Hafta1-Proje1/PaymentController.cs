using Microsoft.AspNetCore.Mvc;

namespace Hafta1_Proje1.Controllers
{

    
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public string Amounts(double capital, int date)
        {
            double interestRate = 0.15;
            double total = capital * (1 + interestRate);
            double interest = (capital * (1 + interestRate)) - capital;
            double monthly = capital * (1 + interestRate) / date;
            var result = "Total payment amount: " + Math.Round(total, 3) + " ₺" + "\nTotal interest amount: " + Math.Round(interest, 3) + " ₺" + "\nMonthly payment amount: " + Math.Round(monthly, 2) + " ₺";

            return result;
        }

        [HttpGet(Name = "GetWeatherForecast2")]
        public string Amounts2(double capital, int date)
        {
            double interestRate = 0.15;
            double total = capital * (1 + interestRate);
            double interest = (capital * (1 + interestRate)) - capital;
            double monthly = capital * (1 + interestRate) / date;
            var result = "Total payment amount: " + Math.Round(total, 3) + " ₺" + "\nTotal interest amount: " + Math.Round(interest, 3) + " ₺" + "\nMonthly payment amount: " + Math.Round(monthly, 2) + " ₺";

            return result;
        }
    }
}

