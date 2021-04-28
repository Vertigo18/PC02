using Microsoft.EntityFrameworkCore;
using PC02.Models;

namespace PC02.Data
{
    public class ContactoContext : DbContext
    {
        public DbSet<ContactoContext> Contacto { get; set; }

        public ContactoContext(DbContextOptions dco) : base(dco) {

        }
    }
}