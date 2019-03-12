//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUB_CATEGORY_ANSWERS
    {
        public int Assessement_Id { get; set; }
        public int Component_Id { get; set; }
        public bool Is_Component { get; set; }
        public bool Is_Override { get; set; }
        public string Answer_Text { get; set; }
        public int Heading_Pair_Id { get; set; }
    
        public virtual ANSWER_LOOKUP ANSWER_LOOKUP { get; set; }
        public virtual ASSESSMENT ASSESSMENT { get; set; }
    }
}

