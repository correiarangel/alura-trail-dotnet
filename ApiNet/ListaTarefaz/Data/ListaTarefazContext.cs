using ListaTarefaz.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaTarefaz.Data
{
    public class ListaTarefazContext : DbContext
    {
        public ListaTarefazContext(DbContextOptions<ListaTarefazContext> options) : base(options)
        {
        }

        public DbSet<Tarefaz> Tarefazs => Set<Tarefaz>();
    }
}