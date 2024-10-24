namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tariff")]
    public partial class tariff
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Tariff { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Price { get; set; }

        public int? Цена_1_min_mejgorod { get; set; }

        public int? Цена_1_min_gorod { get; set; }

        public int? Цена_1_min_mejdunarod { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TypeOfTariff { get; set; }
    }
}
