using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace In_Out.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Expense name")]
        [Required]
        public string ExpenseName { get; set; }


        [DisplayName("Amount")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Enter a valid Expense Anount")]
        public int Amount { get; set; }
    }
}
