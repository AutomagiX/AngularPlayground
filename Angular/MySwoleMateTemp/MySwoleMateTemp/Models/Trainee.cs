//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySwoleMateTemp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainee()
        {
            this.Messages = new HashSet<Message>();
            this.Messages1 = new HashSet<Message>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Trainer_FK { get; set; }
    
        public virtual MealPlan MealPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages1 { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Trainer Trainer { get; set; }
        public virtual Workout Workout { get; set; }
    }
}
