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
    
    public partial class MealPlan
    {
        public int Id_FK { get; set; }
        public System.DateTime Week { get; set; }
        public int MaxCal { get; set; }
        public int MondayBreakfast_FK { get; set; }
        public int MondayLunch_FK { get; set; }
        public int MondaySupper_FK { get; set; }
        public int TuesdayBreakfast_FK { get; set; }
        public int TuesdayLunch_FK { get; set; }
        public int TuesdaySupper_FK { get; set; }
        public int WednesdayBreakfast_FK { get; set; }
        public int WednesdayLunch_FK { get; set; }
        public int WednesdaySupper_FK { get; set; }
        public int ThursdayBreakfast_FK { get; set; }
        public int ThursdayLunch_FK { get; set; }
        public int ThursdaySupper_FK { get; set; }
        public int FridayBreakfast_FK { get; set; }
        public int FridayLunch_FK { get; set; }
        public int FridaySupper_FK { get; set; }
        public int SaturdayBreakfast_FK { get; set; }
        public int SaturdayLunch_FK { get; set; }
        public int SaturdaySupper_FK { get; set; }
        public int SundayBreakfast_FK { get; set; }
        public int SundayLunch_FK { get; set; }
        public int SundaySupper_FK { get; set; }
    
        public virtual Meal Meal { get; set; }
        public virtual Meal Meal1 { get; set; }
        public virtual Meal Meal2 { get; set; }
        public virtual Meal Meal3 { get; set; }
        public virtual Meal Meal4 { get; set; }
        public virtual Meal Meal5 { get; set; }
        public virtual Meal Meal6 { get; set; }
        public virtual Meal Meal7 { get; set; }
        public virtual Meal Meal8 { get; set; }
        public virtual Meal Meal9 { get; set; }
        public virtual Meal Meal10 { get; set; }
        public virtual Meal Meal11 { get; set; }
        public virtual Meal Meal12 { get; set; }
        public virtual Meal Meal13 { get; set; }
        public virtual Meal Meal14 { get; set; }
        public virtual Meal Meal15 { get; set; }
        public virtual Meal Meal16 { get; set; }
        public virtual Meal Meal17 { get; set; }
        public virtual Meal Meal18 { get; set; }
        public virtual Meal Meal19 { get; set; }
        public virtual Meal Meal20 { get; set; }
        public virtual Meal Meal21 { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}