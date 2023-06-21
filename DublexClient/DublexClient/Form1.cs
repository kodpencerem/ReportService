using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace DublexClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form, ReportService.IReportServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Progress(int percentageCompleted)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            tbxProgressStuation.Text = percentageCompleted.ToString() + " % Completed";
        }

        private void btnProcessReport_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);

            ReportService.ReportServiceClient reportServiceClient = new ReportService.ReportServiceClient(instanceContext);

            reportServiceClient.ProcessReport();
        }
    }
}