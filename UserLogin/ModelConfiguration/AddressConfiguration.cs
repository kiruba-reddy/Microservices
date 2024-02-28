using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserLogin.Models;

namespace UserLogin.ModelConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("e_address");
            builder.HasOne(u => u.user)
               .WithOne(a=>a.Address)
               .HasForeignKey<Address>(a => a.UserId);
            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.City)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Country)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a=>a.PostalCode) 
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
