using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domaine
{
    public class Chanson
    {
        [Key]
        public int ChansonId { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateSortie { get; set; }
        public int Duree { get; set; }
        public StyleMusical StyleMusical { get; set; }
        [MinLength(3),MaxLength(12, ErrorMessage ="max 12")]
        public string Titre { get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="vueYtb positif")]
        public int vuesYoutube { get; set; }
        public int ArtisteFk { get; set; }

        [ForeignKey("ArtisteFk")]
        public virtual Artiste Artiste { get; set; }

    }
}
