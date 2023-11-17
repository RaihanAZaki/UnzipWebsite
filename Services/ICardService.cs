using TesterZip.Models.Excel;

namespace TesterZip.Services
{
    public interface ICardService
    {
        List<IDCard> GetIDCards();
        List<IDCard> SaveCard(List<IDCard> card);
    }
}
