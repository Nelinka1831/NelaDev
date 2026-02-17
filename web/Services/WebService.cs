using web.Models;

namespace web.Services
{
    public class WebService : IWebService
    {
        public Numbers AnalyzeValues(string numbersInput)
        {
            var separator = new[] { ',', ' ' };
            var values = numbersInput.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x.Trim())).ToArray();

            return new Numbers
            {
                InputValues = numbersInput,
                Values = values,
                UniqueValues = values.Distinct().ToList(),
                RepeatedValues = values.GroupBy(x => x).Where(x => x.Count() > 1).ToDictionary(x => x.Key, x => x.Count())
            };
        }
    }
}
