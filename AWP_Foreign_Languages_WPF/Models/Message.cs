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
    
    public partial class Message
    {
        public int IdMessage { get; set; }
        public int IdClientMessage { get; set; }
        public int IdTeacherMessage { get; set; }
        public string TextMessage { get; set; }
        public System.DateTime DateMessage { get; set; }
        public System.TimeSpan TimeMessage { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}