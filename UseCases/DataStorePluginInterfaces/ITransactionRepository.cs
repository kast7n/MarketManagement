using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        void Add(string cashierName, int productId, string name, double price, int beforeQty, int soldQty);
        IEnumerable<Transaction> GetByDayAndCashier(string cashierName, DateTime now);
        IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate);
    }
}