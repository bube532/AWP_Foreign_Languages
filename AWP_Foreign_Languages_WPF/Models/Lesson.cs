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
    
    public partial class Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson()
        {
            this.Attendance = new HashSet<Attendance>();
            this.LessonTeacher = new HashSet<LessonTeacher>();
        }
    
        public int IdLesson { get; set; }
        public Nullable<int> LanguageIdLesson { get; set; }
        public int ServiceIdLesson { get; set; }
        public System.DateTime DateLesson { get; set; }
        public System.TimeSpan TimeLesson { get; set; }
        public int IdTeacherLesson { get; set; }
        public string HomeworkLesson { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual Teacher Teacher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LessonTeacher> LessonTeacher { get; set; }
    }
}