//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioAlmacen
{
    using System;
    using System.Collections.Generic;
    
    public partial class producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string modelo { get; set; }
        public string precio { get; set; }
        public byte[] foto { get; set; }
        public Nullable<int> categoria_id { get; set; }
        public Nullable<int> marca_id { get; set; }
    
        public virtual categoria categoria { get; set; }
        public virtual marca marca { get; set; }
    }
}
