using Examen.ApplicationCore.Domaine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configuration
{
    public class ConcertConfiguration : IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasOne(c => c.Artiste)
                .WithMany(c => c.Concerts)
                .HasForeignKey("ArtisteFk");
            builder.HasOne(c => c.Festival)
                .WithMany(c => c.Concerts)
                .HasForeignKey("FestivalFk");
            builder.HasKey(c => new
            {
                c.ArtisteFk,
                c.FestivalFk,
                c.DateConcert
            });
        }
    }
}
