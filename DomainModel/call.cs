namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("call")]
    public partial class call
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Call { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Time_of_start { get; set; }

        public int Amount { get; set; }

        public int? Price { get; set; }

        [Column("ID_User(FK)")]
        public int ID_User_FK_ { get; set; }

        [Column("ID_Type_of_Call(FK)")]
        public int ID_Type_of_Call_FK_ { get; set; }
    }
}
