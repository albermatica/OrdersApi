using System.ComponentModel.DataAnnotations;

namespace OrdersApi.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido del cliente es obligatorio.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 50 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El email del cliente es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del email no es válido.")]
        [StringLength(100, ErrorMessage = "El email no puede exceder los 100 caracteres.")]
        public string Email { get; set; }

        // Propiedad de navegación: Un cliente puede tener muchos pedidos.
        public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    }
}
