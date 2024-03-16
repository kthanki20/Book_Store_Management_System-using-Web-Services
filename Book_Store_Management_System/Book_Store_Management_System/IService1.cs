using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Book_Store_Management_System
{
    
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Insert(Register user);

        [OperationContract]
        bool Update(Register user);

        [OperationContract]
        bool Delete(string email);

        [OperationContract]
        bool login(string username, string password);


    }

   
}
