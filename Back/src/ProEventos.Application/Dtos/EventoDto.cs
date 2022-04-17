using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MinLength(3, ErrorMessage ="{0} deve ter no mínimo 4 caracteres")]
        [MaxLength(50, ErrorMessage ="{0} deve ter no máximo 50 caracteres")]
        public string Tema { get; set; }
        [Display(Name = "Quantidade de pessoas")]
        [Range(1,120000, ErrorMessage = "{0} não pode ultrapassar 120k")]
        public int QtdPessoas { get; set; }
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$")]
        public string ImagemURL { get; set; }
        [Phone(ErrorMessage = "{0} inválido")]
        public string Telefone { get; set; }
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage ="O {0} digitado nao é válido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}