using System.ServiceModel;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(IReportServiceCallBack))]
    public interface IReportService
    {
        [OperationContract]
        void ProcessReport();
    }

    public interface IReportServiceCallBack
    {
        [OperationContract]
        void Progress(int percentageCompleted);
    }
}
