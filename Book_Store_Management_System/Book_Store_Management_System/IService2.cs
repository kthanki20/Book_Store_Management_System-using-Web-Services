using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [ServiceContract]

    public interface IService2
    {
       
            [OperationContract]
            bool Insert(Book book);

            [OperationContract]
            bool Update(Book book);

            [OperationContract]
            bool Delete(string title);
    }
}
