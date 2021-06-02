using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hudelsis_P1_AP2.Models
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar vacio el campo 'ProductoId'")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "No debe de estar vacio el campo 'Descripcion'")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "No debe de estar vacio el campo 'Existencia'")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "No debe de estar vacio el campo 'Costo'")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "No debe de estar vacio el campo 'Inventario'")]
        public decimal ValorInventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }

        public Productos(int productoId, string descripcion,int existencia, decimal costo, decimal valorInventario )
        {
            ProductoId = productoId;
            Descripcion = descripcion;
            Existencia = existencia;
            Costo = costo;
            ValorInventario = valorInventario;
   

        }





    }
}
