namespace LibraTrack.Infra.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Id)
               .HasConversion(userId => userId.Value, value => new(value));
        
        builder.Property(user => user.FirstName)
               .HasMaxLength(200)
               .HasConversion(firstName => firstName.Value, value => new(value));

        builder.Property(user => user.LastName)
               .HasMaxLength(200)
               .HasConversion(firstName => firstName.Value, value => new(value));

        builder.Property(user => user.Email)
               .HasMaxLength(400)
               .HasConversion(email => email.Value, value => new(value));

        builder.Property(user => user.Gender)
               .HasConversion(new EnumToStringConverter<Gender>());
        
        builder.HasIndex(user => user.Email).IsUnique();

        builder.HasIndex(user => user.IdentityId).IsUnique();
    }
}