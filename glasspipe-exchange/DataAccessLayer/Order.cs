namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public int CustomerID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Order_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime Delivery_Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Tracking_Number { get; set; }

        [Required]
        public string PayPay_Info { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Product Product { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
