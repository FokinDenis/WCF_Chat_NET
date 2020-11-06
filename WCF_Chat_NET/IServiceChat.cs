using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Chat_NET
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceChat" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IServiceScatCallBack))]
    public interface IServiceChat
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void DisConnect(int id);

        [OperationContract(IsOneWay = true) ]
        void SendMSG(string msg, int id);
    }

    public interface IServiceScatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallBack(string msg);
    }
}

