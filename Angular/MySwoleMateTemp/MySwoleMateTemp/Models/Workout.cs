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
    
    public partial class Workout
    {
        public int ID_FK { get; set; }
        public System.DateTime Date { get; set; }
        public int ex1 { get; set; }
        public int ex1Reps { get; set; }
        public Nullable<int> ex2 { get; set; }
        public Nullable<int> ex2Reps { get; set; }
        public Nullable<int> ex3 { get; set; }
        public Nullable<int> ex3Reps { get; set; }
        public Nullable<int> ex4 { get; set; }
        public Nullable<int> ex4Reps { get; set; }
        public Nullable<int> ex5 { get; set; }
        public Nullable<int> ex5Reps { get; set; }
        public Nullable<int> ex6 { get; set; }
        public Nullable<int> ex6Reps { get; set; }
        public Nullable<int> ex7 { get; set; }
        public Nullable<int> ex7Reps { get; set; }
        public Nullable<int> ex8 { get; set; }
        public Nullable<int> ex8Reps { get; set; }
        public Nullable<int> ex9 { get; set; }
        public Nullable<int> ex9Reps { get; set; }
        public Nullable<int> ex10 { get; set; }
        public Nullable<int> ex10Reps { get; set; }
    
        public virtual Exercis Exercis { get; set; }
        public virtual Exercis Exercis1 { get; set; }
        public virtual Exercis Exercis2 { get; set; }
        public virtual Exercis Exercis3 { get; set; }
        public virtual Exercis Exercis4 { get; set; }
        public virtual Exercis Exercis5 { get; set; }
        public virtual Exercis Exercis6 { get; set; }
        public virtual Exercis Exercis7 { get; set; }
        public virtual Exercis Exercis8 { get; set; }
        public virtual Exercis Exercis9 { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}