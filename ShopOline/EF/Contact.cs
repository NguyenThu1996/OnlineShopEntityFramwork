namespace ShopOline.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public int ID { get; set; }

        [Column("Contact", TypeName = "ntext")]
        public string Contact1 { get; set; }

        public bool? Status { get; set; }
    }
}
