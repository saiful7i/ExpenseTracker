using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WebApplication1.Data;
using WebApplication1.Models;

namespace Expense_Tracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly TransactionDB _context;

        public DashboardController(TransactionDB context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            //last 7days
            DateTime StratDate = DateTime.Today.AddDays(-6);
            DateTime EndDate = DateTime.Today;

            List<Transaction> SelectTransactions = await _context.Transaction
                .Include(x => x.Category)
                .Where(y => y.Date >= StratDate && y.Date <= EndDate)
                .ToListAsync();


            //Total Income
            int TotalIncome = SelectTransactions
                .Where(i => i.Category.Type == "Income")
                .Sum(j => j.Amount);
            ViewBag.TotalIncome = TotalIncome.ToString("C0");

            //Total Expense
            int TotalExpense = SelectTransactions
                .Where(i => i.Category.Type == "Expense")
                .Sum(j => j.Amount);
            ViewBag.TotalExpense = TotalExpense.ToString("C0");

            //Balance Amount
            int BalanceAmount = TotalIncome - TotalExpense;
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            ViewBag.BalanceAmount = String.Format(culture, "{0:C0}", BalanceAmount);

            //Doughnut Chart - Expense By Category
            ViewBag.DoughtnutChartData = SelectTransactions
                .Where(i => i.Category.Type == "Expense")
                .GroupBy(j => j.Category.categoryId)
                .Select(k => new
                {
                    categoryTitleWithIcon = k.First().Category.Icon + " " + k.First().Category.Title,
                    amount = k.Sum(j => j.Amount),
                    formattedAmount = k.Sum(j => j.Amount).ToString("C0"),
                });


            return View();
        }
    }
}
