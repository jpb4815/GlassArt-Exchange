namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreID { get; set; }

        [Required]
        public string Products { get; set; }

        public int UserID { get; set; }

        public int CategoriesID { get; set; }

        public int ArtistID { get; set; }

        public virtual Artist Artist { get; set; }

        public virtual User User { get; set; }
    }
}
