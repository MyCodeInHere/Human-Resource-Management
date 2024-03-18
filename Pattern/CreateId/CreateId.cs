using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourceManagement.Pattern.CreateId
{
    public class CreateId<T> where T : class
    {
        private readonly HumanResourceManagementDbContext _dbContext;

        public CreateId(HumanResourceManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string GetID(string prefix, int length, int numRow)
        {
            int number = numRow + 1;
            string idNumber = number.ToString().PadLeft(length - prefix.Length, '0');
            string id = prefix + idNumber;
            return id;
        }

        public async Task<string> GetUniqueID(string prefix, int length, string primaryKeyColumnName)
        {
            int count = await _dbContext.Set<T>().CountAsync();
            string newId = GetID(prefix, length, count);
            bool isUnique = false;
            while (!isUnique)
            {
                if (!await _dbContext.Set<T>().AnyAsync(e => EF.Property<string>(e, primaryKeyColumnName) == newId))
                {
                    isUnique = true;
                }
                count++;
                newId = GetID(prefix, length, count);
            }

            return newId;
        }
    }
}