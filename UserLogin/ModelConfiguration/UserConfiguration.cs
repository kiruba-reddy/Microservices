using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserLogin.models;
namespace UserLogin.ModelConfiguration;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("e_users");
        builder.HasKey(u => u.UserId);
        builder.Property(u => u.UserId)
            .ValueGeneratedNever();
        builder.Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(50);
        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(128);
        builder.Property(u => u.Password)
            .IsRequired()
            .HasMaxLength(128);
        
    }
}
