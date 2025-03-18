using System.Threading.Tasks;
using WinFormsMulitThreadingApp.Services;

namespace WinFormsMulitThreadingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            new PrintService().Print();
        }

        private void btnTrhead_Click(object sender, EventArgs e)
        {
            new PrintService().PrintViaThread();
            MessageBox.Show("Thread completed");
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            new PrintService().PrintViaTask();
            MessageBox.Show("Task completed");
        }

        private async void btnTaskAwait_Click(object sender, EventArgs e)
        {
            await new PrintService().PrintViaTaskAwaitable();
            MessageBox.Show("Task completed after 10seconds");
        }

        private async void btnTaskResult_Click(object sender, EventArgs e)
        {

            string result = await new PrintService().PrintViaTaskAwaitableResult();
            MessageBox.Show("task complted after 10 second " + result);
        }

        private async void callMicroservice_Click(object sender, EventArgs e)
        {
            var httpclient = new HttpClient();
            var response =  await httpclient.GetAsync("https://localhost:7126/api/v1/CatalogItem");
            var strignResult = await response.Content.ReadAsStringAsync();
            MessageBox.Show(strignResult);
        }
    }
}
