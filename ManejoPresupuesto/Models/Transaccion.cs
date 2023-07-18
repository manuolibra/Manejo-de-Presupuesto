﻿using Microsoft.SqlServer.Server;
using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Transaccion
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        [Display(Name = "Fecha de Transacción")]
        [DataType(DataType.Date)]
        public DateTime FechaTransaccion { get; set; } = DateTime.Today;
        public decimal Monto { get; set; }
        [Range(0, maximum: int.MaxValue, ErrorMessage = "Debes seleccionar una categoría")]
        [Display(Name ="Categoría")]
        public int CategoriaId { get; set; }
        [StringLength(maximumLength:1000, ErrorMessage = "La nota no puede pasar de {1} caracteres")]
        public string Nota { get; set; }
        [Range(0, maximum: int.MaxValue, ErrorMessage = "Debes seleccionar una cuenta")]
        [Display(Name = "Cuenta")]
        public int CuentaId { get; set; }
        [Display(Name = "Tipo de Operación")]
        public TipoOperacion TipoOperacionId { get; set; } = TipoOperacion.Ingreso;
        public string Cuenta { get; set; }
        public string Categoria { get; set; }
    }
}
