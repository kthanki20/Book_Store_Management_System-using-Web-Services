using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        bool Insert(Order order);

        [OperationContract]
        bool Update(Order order);

        [OperationContract]
        bool Delete(int order_id);

        [OperationContract]
        Dictionary<int, string> FetchBooks();

        [OperationContract]

        int FetchId(string username);
    }
}
