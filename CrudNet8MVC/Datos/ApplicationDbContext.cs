using CrudNet8MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet8MVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Agregar los modelo aqui(Cada model corresponde a una tabla en la BD)
        public DbSet<Contacto> Contacto { get; set; }
    }
}
