using Microsoft.EntityFrameworkCore;
using ContactsWebApi.Models;

namespace ContactsWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}