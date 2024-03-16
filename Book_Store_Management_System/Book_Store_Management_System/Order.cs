using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]

        public DateTime order_date { get; set; }

        [DataMember]

        public int book_id { get; set; }

        [DataMember]

        public int price { get; set;}

        [DataMember]

        public byte[] Image { get; set; }

    }
}
