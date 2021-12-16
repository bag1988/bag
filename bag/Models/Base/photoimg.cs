namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class photoimg
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idPhotoImg { get; set; }

        public int? idPhoto { get; set; }

        public string urlImg { get; set; }

        public string urlSmall { get; set; }

        [Column(TypeName = "text")]
        public string textImg { get; set; }
    }
}
