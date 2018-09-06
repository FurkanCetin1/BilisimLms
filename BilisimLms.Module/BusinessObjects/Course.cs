using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilisimLms.Module.BusinessObjects
{
    [DefaultClassOptions]
    [System.ComponentModel.DefaultProperty("Title")]
    [NavigationItem("Modüller")]
    public class Course : BaseObject
    {
        public Course(Session session) : base(session) { }
        private string name;
        [DisplayName("Ders Adı")]
        [FieldSize(200)]
        public string Name
        {
            get { return name; }
            set { SetPropertyValue("Name", ref name, value); }
        }
        private string description;
        [DisplayName("Açıklama")]
        [FieldSize(FieldSizeAttribute.Unlimited)]
        public string Description
        {
            get { return description; }
            set { SetPropertyValue("Description", ref description, value); }
        }
    }
}
