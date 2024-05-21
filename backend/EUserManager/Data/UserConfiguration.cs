using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static EUserManager.Data.EntityUser;


namespace EUserManager.Data
{
    public class UserConfiguration: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username);

            builder.Property(x => x.Email);

            builder.Property(x => x.Password);




        }
    }
}
