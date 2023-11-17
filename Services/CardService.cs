using EFCore.BulkExtensions;
using TesterZip.Context;
using TesterZip.Models.Excel;

namespace TesterZip.Services
{
    public class CardService : ICardService
    {
        DatabaseContext _dbContext = null;

        public CardService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<IDCard> GetIDCards()
        {
            return _dbContext.IDCards.ToList();
        }

        public List<IDCard> SaveCard(List<IDCard> card)
        {
            _dbContext.BulkInsert(card);
            return card;
        }
    }
}
