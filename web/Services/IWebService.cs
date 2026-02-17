using web.Models;

namespace web.Services
{
    public interface IWebService
    {
        Numbers AnalyzeValues(string numbersInput);
    }
}
