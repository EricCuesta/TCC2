//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantoã_Arquitetura.Database.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_benefits
    {
        public int id_benefits { get; set; }
        public int id_emp { get; set; }
        public Nullable<bool> bt_food { get; set; }
        public Nullable<bool> bt_transport { get; set; }
        public Nullable<bool> bt_meal { get; set; }
        public Nullable<bool> bt_lifeSafe { get; set; }
        public Nullable<bool> bt_planHealth { get; set; }
        public Nullable<bool> bt_planDental { get; set; }
    }
}
