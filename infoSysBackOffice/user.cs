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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.requests = new HashSet<request>();
        }
    
        public int idUsera { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string otchestvo { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string telephone { get; set; }
        public string dolz { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<request> requests { get; set; }

        public user(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public user(string email, string surname, string name, string otchestvo, string city, string telephone, string dolz)
        {
            this.email = email;
            this.surname = surname;
            this.name = name;
            this.otchestvo = otchestvo;
            this.city = city;
            this.telephone = telephone;
            this.dolz = dolz;
        }
    }
}