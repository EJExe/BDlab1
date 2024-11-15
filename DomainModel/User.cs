namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_User { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone_Number { get; set; }

        public int? MoneyCount { get; set; }

        [Column("ID_Tariff(FK)")]
        public int ID_Tariff_FK_ { get; set; }

        [StringLength(50)]
        public string TypeOfUser { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? MinLeft { get; set; }

        public int? GBLeft { get; set; }
    }
}
