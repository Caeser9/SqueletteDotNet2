using Examen.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configuration
{
    public class ChansonConfiguration : IEntityTypeConfiguration<Chanson>
    {
        public void Configure(EntityTypeBuilder<Chanson> builder)
        {
            //builder.HasOne(c => c.Artiste)
            //    .WithMany(c => c.Chansons)
            //    .HasForeignKey("ArtisteFk");
        }
    }
}
