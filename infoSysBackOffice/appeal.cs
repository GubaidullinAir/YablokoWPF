//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace infoSysBackOffice
{
    using System;
    using System.Collections.Generic;
    
    public partial class appeal
    {
        public int idObras { get; set; }
        public string tema { get; set; }
        public string textobr { get; set; }
    
        public virtual request request { get; set; }
        public virtual chlPart chlPart { get; set; }
    }
}
