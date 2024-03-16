using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [DataContract]
    public class Register
    {
        [DataMember]
        public string first_name { get; set; }

        [DataMember]
        public string last_name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Zip_code { get; set; }

        [DataMember]
        public string phoneNumber { get; set; }

        [DataMember]
        public string DOB { get; set; }

        [DataMember]
        public string Role { get; set; }
    }
}
