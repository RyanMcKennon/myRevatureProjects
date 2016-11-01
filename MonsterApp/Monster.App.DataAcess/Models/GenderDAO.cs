using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Monster.App.DataAcess.Models
{
    [DataContract]
    public class GenderDAO
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}