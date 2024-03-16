using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string title { get; set; }

        [DataMember]
        public string Language { get; set; }
        [DataMember]

        public string Description { get; set; }

        [DataMember] 
        public string publication_year { get; set; }

        [DataMember]

        public int Price { get; set; }

        [DataMember]

        public byte[] Image { get; set; }

        [DataMember]

        public string Status { get; set; }

        [DataMember]

        public string Edition { get; set; }

        [DataMember]

        public string Genre { get; set; }
    }
}
