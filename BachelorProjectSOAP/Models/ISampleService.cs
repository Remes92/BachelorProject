using System.Collections.Generic;
using System.ServiceModel;

namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        
        [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MyCustomModel TestCustomModel(MyCustomModel inputModel);
        [OperationContract]
        List<BachelorProjectBackend.Models.test> TestList();
    }
}