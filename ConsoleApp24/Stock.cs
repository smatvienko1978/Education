//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp24
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int ProductID { get; set; }
        public Nullable<int> Qty { get; set; }
    
        public virtual Product Product { get; set; }
    }
}