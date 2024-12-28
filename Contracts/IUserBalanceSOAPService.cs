using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LESI_ISI_TP2_26052_SOAP2
{
    [ServiceContract]
    public interface IUserBalanceSOAPService
    {
        [OperationContract]
        double GetTotalUnitsForUser(int idUser);
    }
}
