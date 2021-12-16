namespace bag.Models.Base
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
        
    public partial class templatesOptionsBlock
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTemplatesOptionsBlock { get; set; }

        public int? idTemplate { get; set; }

        public int? idProperty { get; set; }

        public int? idModule { get; set; }

        [StringLength(50)]
        public string nameOptions { get; set; }

        [Column(TypeName = "text")]
        public string valueOptions { get; set; }

        [Column(TypeName = "text")]
        public string dopOptions { get; set; }
    }
}
