

namespace VerifyEmailForgetPasswordTutorial.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("SERVER=DESKTOP-3CN4L8E; Database=userdb;User ID=dalintho;Password=Dalin@321; Trusted_Connection = True; TrustServerCertificate = True;");
        }

        public DbSet<User> Users { get; set; }
    }
}
