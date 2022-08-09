using Infrastructure.DataContexts;

namespace Infrastructure.Repositories
{
    public class OrderRepository
    {
        private DataContext _dataContext;

        public OrderRepository(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

    }
}
