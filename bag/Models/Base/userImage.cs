namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class userImage
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUserImage { get; set; }

        public int? idUser { get; set; }

        [StringLength(255)]
        public string smallImages { get; set; }

        [StringLength(255)]
        public string bigImages { get; set; }

        [StringLength(50)]
        public string mainImages { get; set; }
    }
}
