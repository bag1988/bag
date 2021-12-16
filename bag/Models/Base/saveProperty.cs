namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
        
    public partial class saveProperty
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idSaved { get; set; }

        [Column(TypeName = "text")]
        public string nameSave { get; set; }

        public int? idModule { get; set; }

        [Column(TypeName = "text")]
        public string saveHtml { get; set; }

        [Column(TypeName = "text")]
        public string saveCss { get; set; }
    }
}
