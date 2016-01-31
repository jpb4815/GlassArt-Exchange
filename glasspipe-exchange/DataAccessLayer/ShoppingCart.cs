namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCart")]
    public partial class ShoppingCart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShoppingCartID { get; set; }

        public int ProductID { get; set; }

        public int OrderID { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity { get; set; }

        public double Tax_value { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
