using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TO_DO.Domain;
using TO_DO.Domain.SubTask;


namespace TO_DO.Persistence.Configurations
{
    internal class SubTaskConfiguration : IEntityTypeConfiguration<Subtask>
    {
        public void Configure(EntityTypeBuilder<Subtask> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Status).IsRequired().HasConversion(v => v.ToString(), v => (Enums.Status)Enum.Parse(typeof(Enums.Status), v));

            builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("date");

            builder.Property(x => x.ModifiedAt).IsRequired().HasColumnType("date");
        }   
    }
}
