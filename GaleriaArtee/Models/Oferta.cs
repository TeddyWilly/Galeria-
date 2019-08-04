using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaleriaArtee.Models
{
    public class Oferta
    {
        public int Id { get; set; }

        public int ApplicationUserID { get; set; }
        public double ValorOferta { get; set; }

        public DateTime Fecha { get; set; }

        public int Status { get; set; }

        public int Vista { get; set; }


    }
}