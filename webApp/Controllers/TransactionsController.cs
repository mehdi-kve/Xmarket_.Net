using Microsoft.AspNetCore.Mvc;
using CoreBusiness;
using UseCases;
using Microsoft.AspNetCore.Authorization;
using webApp.ViewModels;

namespace WebApp.Controllers
{
    //[Authorize] disabled manually
    public class TransactionsController : Controller
    {
        private readonly ISearchTransactionsUseCase searchTransactionsUseCase;

        public TransactionsController(ISearchTransactionsUseCase searchTransactionsUseCase)
        {
            this.searchTransactionsUseCase = searchTransactionsUseCase;
        }

        public IActionResult Index()
        {
            TransactionsViewModel transactionsViewModel = new TransactionsViewModel();
            return View(transactionsViewModel);
        }

        public IActionResult Search(TransactionsViewModel transactionsViewModel)
        {
            var transactions = searchTransactionsUseCase.Execute(
                transactionsViewModel.CashierName ?? string.Empty,
                transactionsViewModel.StartDate,
                transactionsViewModel.EndDate);

            transactionsViewModel.Transactions = transactions;

            return View("Index", transactionsViewModel);
        }
    }
}