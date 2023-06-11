using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        //Annotation de Chave primaria
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo Título é obrigatorio")]
        [StringLength(60,MinimumLength = 3, ErrorMessage ="O Título precisa ter entre 3 ou 60 caracter")]
        public string Titulo{ get; set; }

        [DataType(DataType.DateTime,ErrorMessage ="Data em formato incorreto")]
        [Required(ErrorMessage = "O campo data de lançamento é obrigatorio")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        //de a a z sendo que a primeira letra é maiúscula
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""\w-]*$", ErrorMessage ="Genero informado não existe")]
        //Duas anotações em uma unica chave a partir da "," 
        [StringLength(30,ErrorMessage ="Maximo de 30 caracteres"),Required(ErrorMessage ="O campo Genero é Obrigatorio")]
        public string Genero { get; set; }
        
        
        [Range(1,100,ErrorMessage ="Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor")]
        //Como vai ser a especificação coluna do banco de dados 
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage ="Somente números de 1 a 5")]
        public int Avaliacao { get; set; }

    }
}
