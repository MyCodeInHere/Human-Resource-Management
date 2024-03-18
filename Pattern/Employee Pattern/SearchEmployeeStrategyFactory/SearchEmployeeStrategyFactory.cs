using HumanResourceManagement.Pattern.SearchEmployeeStrategy;

namespace HumanResourceManagement.Controllers
{
    public class SearchEmployeeStrategyFactory
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public SearchEmployeeStrategyFactory(HumanResourceManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ISearchEmployeeStrategy CreateStrategy(string strategyType)
        {
            switch (strategyType)
            {
                case "id":
                    return new IdSearchEmployeeStrategy(_dbContext);
                case "name":
                    return new NameSearchEmployeeStrategy(_dbContext);
                case "phone":
                default:
                    return new PhoneSearchEmployeeStrategy(_dbContext);
            }
        }
    }
}