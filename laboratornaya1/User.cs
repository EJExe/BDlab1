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
    
    public partial class User
    {
        public int ID_User { get; set; }
        public string FIO { get; set; }
        public string Phone_Number { get; set; }
        public Nullable<int> MoneyCount { get; set; }
        public int ID_Tariff_FK_ { get; set; }
        public string TypeOfUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> MinLeft { get; set; }
        public Nullable<int> GBLeft { get; set; }
    }
}
