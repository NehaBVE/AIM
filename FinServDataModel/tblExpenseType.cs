//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinServDataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblExpenseType
    {
        public int AutoID { get; set; }
        public System.Guid ExpenseTypeID { get; set; }
        public string Description { get; set; }
        public string Frequency { get; set; }
        public bool IsActive { get; set; }
    }
}
