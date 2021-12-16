namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class template
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTemplate { get; set; }

        [StringLength(50)]
        public string nameTemplate { get; set; }
    }
}
