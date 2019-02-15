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

        public Form1()
        {
            InitializeComponent();
        }

        private void GetBtn_Click(object sender, EventArgs e)
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

                var response = httpClient.GetStringAsync(new Uri(url)).Result; // Calling GET API

               ///*
                // Process GET API response data
                var json = new JavaScriptSerializer();
                var serializer = new JavaScriptSerializer();
                var deserializedResult = serializer.Deserialize<List<EmersonJd>>(response);
                //*/


                ///*
                // Dynamically add the dropdown items from the GET API result
                comboBoxDDL.Items.Clear();// clear the previous dropdown items
                for (var i = 0; i < deserializedResult.Count; i++)
                {
                    comboBoxDDL.Items.Add(new ListItem(deserializedResult[i].dayWk, deserializedResult[i].dateObj.timeVal.ToString()));
                }
                //*/

            }

        }
    }
}
