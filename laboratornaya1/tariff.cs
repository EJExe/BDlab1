//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace laboratornaya1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tariff
    {
        public int ID_Tariff { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Nullable<int> Цена_1_min_mejgorod { get; set; }
        public Nullable<int> Цена_1_min_gorod { get; set; }
        public Nullable<int> Цена_1_min_mejdunarod { get; set; }
        public string TypeOfTariff { get; set; }
    }
}
