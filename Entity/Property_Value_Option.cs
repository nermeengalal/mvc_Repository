//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property_Value_Option
    {
        public int ID { get; set; }
        public int Property_Option_ID { get; set; }
        public int Property_Value_ID { get; set; }
    
        public virtual Property_Options Property_Options { get; set; }
        public virtual Property_Value Property_Value { get; set; }
    }
}
