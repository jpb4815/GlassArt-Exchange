namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressID { get; set; }

        [Column("Address_Line 1")]
        [Required]
        [StringLength(50)]
        public string Address_Line_1 { get; set; }

        [Column("Address_Line 2")]
        [StringLength(50)]
        public string Address_Line_2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string Zip_Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Telephone_2 { get; set; }

        public int UserID { get; set; }

        public virtual User User { get; set; }
    }
}
