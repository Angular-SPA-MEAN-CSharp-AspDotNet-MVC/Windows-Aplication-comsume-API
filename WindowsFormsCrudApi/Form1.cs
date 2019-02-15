using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;

namespace WindowsFormsCrudApi
{
    public partial class Form1 : Form
    {
        private class DateObj
        {
            public DateTime timeVal
            {
                get;
                set;
            }
        }

        private class EmersonJd
        {
            public string dayWk
            {
                get;
                set;
            }
            public bool urlSpecified
            {
                get;
                set;
            }

            public DateObj dateObj
            {
                get;
                set;
            }
        }

        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void GetBtn_Click(object sender, EventArgs e)
        {
            updateOrInitDropDown();
        }

        private void PostBtn_Click(object sender, EventArgs e)
        {
            string url;

            // POST API URI
            if (ApiTextBox.Text != "")
            {
                url = ApiTextBox.Text;
            }
            else
            {
                url = "http://localhost:21884/api/Emerson";
            }

            // directly hardcoded hte Deserilized input. 
            var rowString = "[{\"dayWk\":\"Posted-0.Sunday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-14T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-1.Monday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-15T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-2.Tuesday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-16T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-3.Wednesday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-17T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-4.Thursday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-18T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-5.Friday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-19T00:21:29.5232184-05:00\"}}," +
                "{\"dayWk\":\"Posted-6.Satday\",\"urlSpecified\":true,\"dateObj\":{\"timeVal\":\"2019-02-20T00:21:29.5232184-05:00\"}}]";

            //Just for reference
            /*
            object data = new
            {
                name = "Foo",
                category = "article"
            };
            var serializer = new JavaScriptSerializer();
            var myContent = serializer.Serialize(data); // myContent is the rowString!!!
            */

            // 
            // Directly "Simple Way", just for reference
            //var content = new FormUrlEncodedContent(values);            
            //var response = client.PostAsync(url, content);

            var buffer = System.Text.Encoding.UTF8.GetBytes(rowString);
            var byteContent = new ByteArrayContent(buffer);

            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = client.PostAsync(url, byteContent).Result;

            updateOrInitDropDown();
        }

        // This function is used to load the date for the dropDown, if no data, the dropDown will grab data from API
         private void updateOrInitDropDown()
        {
            using (var httpClient = new HttpClient())
            {
                string url;

                // GET API URI
                if (ApiTextBox.Text != "")
                {
                    url = ApiTextBox.Text;
                }
                else
                {
                    url = "http://localhost:21884/api/Emerson";
                }

                try
                {
                    var response = httpClient.GetStringAsync(new Uri(url)).Result; // Calling GET API
                                       
                    // Process GET API response data
                    var json = new JavaScriptSerializer();
                    var serializer = new JavaScriptSerializer();
                    var deserializedResult = serializer.Deserialize<List<EmersonJd>>(response);

                    // Dynamically add the dropdown items from the GET API result
                    comboBoxDDL.Items.Clear();// clear the previous dropdown items
                    for (var i = 0; i < deserializedResult.Count; i++)
                    {
                        comboBoxDDL.Items.Add(new ListItem(deserializedResult[i].dayWk, deserializedResult[i].dateObj.timeVal.ToString()));
                    }
                }
                catch
                {
                    // Some error cases:
                    // Either the APIs are not set up, or the API can not handle
                }

            }
        }
    }
}
