using System.ServiceModel;
using System.Threading;

namespace ReportService
{
    [ServiceBehavior(ConcurrencyMode =ConcurrencyMode.Reentrant)]
    public class ReportService : IReportService
    {

        public void ProcessReport()
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                OperationContext.Current.GetCallbackChannel<IReportServiceCallBack>().Progress(i);
            }
        }
    }
}
