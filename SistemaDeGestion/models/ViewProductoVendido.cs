using System;
using System.Collections.Generic;

namespace SistemaDeGestion.models
{
    public partial class ViewProductoVendido
    {
        public int Id { get; set; }
        public string Descripciones { get; set; } = null!;
        public decimal? Costo { get; set; }
        public int IdVenta { get; set; }
        public int Stock { get; set; }
    }
}
