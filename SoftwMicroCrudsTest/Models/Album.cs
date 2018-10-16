using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SoftwMicroCrudsTest.Models
{
    public class Album
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O Nome deve ser informado")]
        [StringLength(25, MinimumLength = 2, ErrorMessage ="O nome deve ter no minimo 2 caracteres")]
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? DataCriacao { get; set; }

        public DateTime DataAtualizacao { get; set; }

        public List<Foto> Fotolist { get; set; }

        public Image Imagem { get; set; }

        public string Link { get; set; }

        public Album(int Id, string Nome, DateTime DataAtualizacao)
        {
            this.Codigo = Id;
            this.Nome = Nome;
            this.DataAtualizacao = DataAtualizacao;
        }

        public Album()
        {

        }

    }
}