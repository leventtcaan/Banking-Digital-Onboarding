using System.ComponentModel.DataAnnotations;
namespace Banking_Digital_Onboarding.Models
{
    public class CustomerApplication
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad Soyad alanı zorunludur.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad Soyad en az 3, en fazla 50 karakter olmalıdır.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "TC Kimlik Numarası zorunludur.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik Numarası tam 11 haneli olmalıdır.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "TC Kimlik Numarası sadece rakamlardan oluşmalıdır.")]
        public string NationId { get; set; }

        [Required(ErrorMessage = "Aylık gelir belirtmek zorunludur.")]
        [Range(28000, 1000000, ErrorMessage = "Aylık geliriniz asgari ücretin (28000 TL) altında olamaz.")]
        public decimal MonthlyIncome { get; set; }

        [Required(ErrorMessage = "Lütfen bir başvuru tipi seçiniz.")]
        public string ApplicationType { get; set; }
    }
}