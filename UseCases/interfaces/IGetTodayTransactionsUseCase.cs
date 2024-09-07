using CoreBusiness;

namespace UseCases.TransactionsUseCase
{
    public interface IGetTodayTransactionsUseCase
    {
        IEnumerable<Transaction> Execute(string cashierName);
    }
}