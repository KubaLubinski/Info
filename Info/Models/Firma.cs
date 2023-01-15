using System.ComponentModel.DataAnnotations;

namespace Info.Models
{
    public class Firma
    {
        [Key]
        [Display(Name = "Identyfikator firmy:")]
        public int IdFirmy { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwę firmy")]
        [Display(Name = "Nazwa firmy:")]
        [MaxLength(60, ErrorMessage = "Nazwa firmy nie może być dłuższa niż 60 znaków")]
        public string? Nazwa { get; set; }

        [Required(ErrorMessage = "Prosze podać pełną nazwę firmy")]
        [Display(Name = "Pełna nazwa firmy:")]
        [MaxLength(150, ErrorMessage = "Pełna nazwa firmy nie może być dłuższa niż 150 znaków")]
        public string? PelnaNazwa { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwę miejscowości")]
        [Display(Name = "Nazwa miejsocowości:")]
        [MaxLength(50, ErrorMessage = "Nazwa miejscowości nie może być dłuższa niż 50 znaków")]
        public string? Miejscowosc { get; set; }

        [Required(ErrorMessage = "Prosze podać kod pocztowy")]
        [Display(Name = "Kod pocztowy:")]
        [MaxLength(50, ErrorMessage = "Kod pocztowy nie może być dłuższy niż 50 znaków")]
        public string? KodPocztowy { get; set; }

        [Required(ErrorMessage = "Prosze podać nazwę ulicy")]
        [Display(Name = "Nazwa ulicy:")]
        [MaxLength(50, ErrorMessage = "Nazwa ulicy nie może być dłuższa niż 50 znaków")]
        public string? Ulica { get; set; }

        [Required(ErrorMessage = "Prosze podać numer telefonu")]
        [Display(Name = "Numer telefonu:")]
        [MaxLength(50, ErrorMessage = "Numer telefonu nie może być dłuższy niż 50 znaków")]
        public string? Telefon { get; set; }

        [Required(ErrorMessage = "Prosze podać adres e-mail")]
        [Display(Name = "Adres e-mail:")]
        [MaxLength(60, ErrorMessage = "Adres e-mail nie może być dłuższy niż 60 znaków")]
        public string? Mail { get; set; }
    }
}
