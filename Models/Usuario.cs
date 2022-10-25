using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto24Bm.Models
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Name { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        [ForeignKey("Roles")]
        public int FkRol { set; get; }
        public Rol Roles { get; set; }
    }
}
