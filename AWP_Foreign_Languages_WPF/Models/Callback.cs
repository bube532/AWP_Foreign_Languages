//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AWP_Foreign_Languages_WPF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Callback
    {
        public int IdCallback { get; set; }
        public int IdClientCallback { get; set; }
        public string TextCallback { get; set; }
        public System.TimeSpan TimeCallback { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
