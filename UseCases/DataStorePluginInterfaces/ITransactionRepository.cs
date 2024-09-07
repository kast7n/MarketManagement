using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        void Add(string cashierName, int productId, string name, double v1, int v2, int qty);
        IEnumerable<Transaction> GetByDayAndCashier(string cashierName, DateTime now);
        IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);
    }
}