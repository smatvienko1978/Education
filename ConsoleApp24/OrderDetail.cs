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
    
    public partial class OrderDetail
    {
        public int OrderID { get; set; }
        public int LineItem { get; set; }
        public Nullable<int> ProductID { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
