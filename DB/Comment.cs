//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentID { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string CommentText { get; set; }
        public Nullable<System.DateTime> CommentOn { get; set; }
        public string UserName { get; set; }
        public string PictureName { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}
