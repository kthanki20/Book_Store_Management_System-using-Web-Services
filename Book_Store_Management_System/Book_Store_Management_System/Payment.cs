using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int order_id {  get; set; }

        [DataMember]
        public string payment_Status {  get; set; }

        [DataMember]

        public string payment_Method {  get; set; }



    }
}
