using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace RestApiExample
{
    public partial class ApiInterface : Form
    {
        private String endpoint = "http://api.kawalcorona.com/";
        private String endpoint_accept_type = "application/json";

        HttpClient apiKawalKorona;

        public ApiInterface()
        {
            InitializeComponent();
        }

        private void pripareApi()
        {
            Console.WriteLine("Priparing Http...");

            this.apiKawalKorona = new HttpClient();
            this.apiKawalKorona.BaseAddress = new Uri(this.endpoint);

            this.apiKawalKorona.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(this.endpoint_accept_type)
            );

            Console.WriteLine("Http Ready");
        }

        private JArray getData()
        {
            Console.WriteLine("Fetching Data..");

            HttpResponseMessage res = this.apiKawalKorona.GetAsync("/").Result;
            if (!res.IsSuccessStatusCode)
            {
                Console.WriteLine("Error to get data");
            }

            String jsonString = res.Content.ReadAsStringAsync().Result;

            JArray jsonArray = JArray.Parse(jsonString);

            Console.WriteLine("Fetch Complete");
            return jsonArray;
        }

        private void ApiInterface_Load(object sender, EventArgs e)
        {
            this.pripareApi();

            JArray data = this.getData();

            int i = 0;
            foreach(JObject obj_row in data) {
                
                // Dynamic karna tidak ada interface
                dynamic row = obj_row.GetValue("attributes");

                table.Rows.Add();
                table.Rows[i].Cells[0].Value = row.Country_Region;
                table.Rows[i].Cells[1].Value = row.Confirmed;
                table.Rows[i].Cells[2].Value = row.Deaths;
                table.Rows[i].Cells[3].Value = row.Recovered;
                table.Rows[i].Cells[4].Value = row.Active;

                i++;
            }
        }
    }
}
