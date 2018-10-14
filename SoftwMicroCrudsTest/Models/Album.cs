using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SoftwMicroCrudsTest.Models
{
    public class Album
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }

        private List<Foto> Fotolist { get; set; }

        private Image Imagem { get; set; }

        private string Link { get; set; }
    }
}