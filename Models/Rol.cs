using System.ComponentModel.DataAnnotations;

namespace Proyecto24Bm.Models
{
    public class Rol
    {
        [Key]
        public int PkRol { get; set; }
        public string Name { get; set; }

    }
}
