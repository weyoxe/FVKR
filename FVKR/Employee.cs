//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FVKR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Receptions = new HashSet<Reception>();
        }
    
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string Phone_Number { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Position { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public Nullable<bool> Sign { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reception> Receptions { get; set; }
    }
}