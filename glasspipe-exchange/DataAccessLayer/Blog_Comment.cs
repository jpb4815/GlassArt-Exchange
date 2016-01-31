namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Blog_Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogCommentID { get; set; }

        public int BlogID { get; set; }

        [Required]
        public string Comment_Body { get; set; }

        [StringLength(50)]
        public string Comment_Author { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
