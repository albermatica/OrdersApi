using System; // Para DateTime
using System.ComponentModel.DataAnnotations; // Para Data Annotations
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace OrdersApi.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha del pedido es obligatoria.")]
        public DateTime FechaPedido { get; set; } = DateTime.Now; // Fecha actual por defecto

        [Required(ErrorMessage = "El total del pedido es obligatorio.")]
        [Range(0.01, 100000.00, ErrorMessage = "El total debe estar entre 0.01 y 100000.00.")]
        public decimal Total { get; set; }

        // Clave Foránea (FK): Un pedido pertenece a un cliente.
        [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El ID del cliente debe ser un número positivo.")]
        public int ClienteId { get; set; }

        // Propiedad de Navegación: Un pedido tiene un cliente.
        [ValidateNever] // Ignorar validación para esta propiedad en la entrada JSON
        public virtual Cliente Cliente { get; set; }
    }
}
