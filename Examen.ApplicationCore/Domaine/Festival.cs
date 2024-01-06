using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Festival
    {
        public int Capacite { get; set; }
        [Key]
        public int FestivalId { get; set; }
        public string Label { get; set; }
        public string Ville { get; set; }
        public virtual IList<Concert> Concerts { get; set; }
    }
}
