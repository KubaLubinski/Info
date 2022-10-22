using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Info.Models
{
    public class Category
    {
        [Key] //zbedne
        [Display(Name="Identyfikator kategorii:")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Prosze podać nazwę kategorii")]
        [Display(Name="Nazwa kategorii:")]
        [MaxLength(50, ErrorMessage = "Nazwa kategorii nie może być dłuższa niż 50 znaków")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Prosze podać opis kategorii")]
        [Display(Name = "Opis kategorii:")]
        [MaxLength(255, ErrorMessage = "Opis kategorii nie może być dłuższa niż 255 znaków")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwę ikony")]
        [Display(Name = "Nazwa ikony:")]
        [MaxLength(30, ErrorMessage = "Nazwa ikony nie może być dłuższa niż 30 znaków")]
        public string? Icon { get; set; }

        [Required]
        [Display(Name="Czy kategoria aktywna:")]
        [DefaultValue(true)]
        public bool Active { get; set; }

        [Required]
        [Display(Name = "Czy wyświetlać:")]
        public bool Display { get; set; }

        public virtual List<Text>? Texts { get; set; }
    }
}
