namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class photo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPhoto { get; set; }

        public string namePhoto { get; set; }

        [Column(TypeName = "text")]
        public string textPhoto { get; set; }
    }
}
