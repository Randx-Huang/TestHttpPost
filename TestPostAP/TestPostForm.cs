using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPostAP
{
    public partial class TestPostForm : Form
    {
        public TestPostForm()
        {
            InitializeComponent();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            string inputURL = this.txtURL.Text.Trim();
            string requestBody = meReq.Text;
            if (inputURL == "put your URL in here" || string.IsNullOrEmpty(inputURL))
            {
                txtURL.Focus();
                meReq.Text = "OOPS!!!!Please input your URL in to the textbox";
                return;
            }

            if (string.IsNullOrEmpty(requestBody))
            {
                meReq.Focus();
                MessageBox.Show("請輸入RequestBody");
                return;
            }

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(inputURL);
                btnPost.Enabled = false;
                meRepo.Text = "";
                tabActionControl.SelectedTabPageIndex = 1;
                meRepo.Focus();
                var Result = await PostResult("JSON", client, requestBody);
            }
            catch (Exception ex)
            {
                meRepo.Text = string.Format("exMessage:{0}{3},exStackTrace:{1}{3},InnerException:{2}{3}"
                    , ex.Message
                    , ex.StackTrace
                    , ex.InnerException
                    , Environment.NewLine);
            }
            btnPost.Enabled = true;
        }


        /// Http Get
        /// <summary>
        /// Http Get
        /// </summary>
        /// <param name="client">HttpClient</param>
        /// <param name="url">URL</param>
        /// <returns></returns>
        public static async Task<string> GetResult(HttpClient client)
        {
            var response = await client.GetAsync(client.BaseAddress).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            var body = response.Content.ReadAsStringAsync().Result;
            return body;
        }

        /// Http Post
        /// <summary>
        /// Http Post 
        /// </summary>
        /// <param name="type">JSON;XML;OTHER,Need HttpContent</param>
        /// <param name="url">URL</param>
        /// <param name="client">HttpClient</param>
        /// <param name="requestBody">RequestBodyContent</param>
        /// <param name="httpContent">ContentType...etc.</param>
        /// <returns></returns>
        public async static Task<string> PostResult(string type,
                                                    HttpClient client,
                                                    string requestBody)
        {
            StringContent content;
            HttpResponseMessage response;
            string MediaType = null;
            if (type.ToUpper() == "JSON" || type.ToUpper() == "XML")
            {
              
                if (type.ToUpper() == "JSON")
                {
                    MediaType = "application/json";
                }
                else
                {
                    MediaType = "text/xml";
                }
            }
            content = new StringContent(requestBody, Encoding.UTF8, MediaType);
            response = await client.PostAsync(client.BaseAddress.AbsoluteUri, content);
            response.EnsureSuccessStatusCode();
            var body = response.Content.ReadAsStringAsync().Result;
            return body;
        }

    }
}
