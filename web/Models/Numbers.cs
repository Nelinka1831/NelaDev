using System.ComponentModel.DataAnnotations;

namespace web.Models
{
    public class Numbers
    {
        [Required(ErrorMessage = "Zadejte čísla.")]
        [RegularExpression(@"^(\s*\d+\s*([, ]\s*\d+\s*){2,19})$", ErrorMessage = "Zadejte 3 až 20 čísel oddělených čárkou nebo mezerou.")]
        public string? InputValues { get; set; }

        public int[]? Values { get; set; }
        public List<int>? UniqueValues { get; set; }
        public Dictionary<int, int>? RepeatedValues { get; set; }
    }
}
