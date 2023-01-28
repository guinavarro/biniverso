using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biniverso.Presentation.Models
{
    public class ImageViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [DisplayName("Nome")]
        public string Title { get; set; }
      
        [DisplayName("Descrição")]
        public string? Description { get; set; }
        [DisplayName("Imagem")]
        public FormFile Path { get; set; }
        public DateTime Date { get; set; }
    }
}
