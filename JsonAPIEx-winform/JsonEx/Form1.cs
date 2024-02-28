using Newtonsoft.Json;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace JsonEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string URl = "https://api.codebazan.ir/arz/?type=arz";
            //string URl = "https://mocki.io/v1/e1006c84-e296-4d9c-860f-c4710bcf428b";
            string URl = "https://testapi.devtoolsdaily.com/users?limit=10";

            using (var client = new HttpClient())
            {
                //var result = client.GetStringAsync(URl).Result;
                //var result = "[\r\n        {\r\n            \"name\": \"دلار\",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"یورو\",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"درهم امارات \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"پوند انگلیس\",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"لیر ترکیه \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"فرانک سوئیس \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"یوان چین \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"ین ژاپن (100 ین) \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"وون کره جنوبی\",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دلار کانادا \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دلار استرالیا \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دلار نیوزیلند \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دلار سنگاپور \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"روپیه هند \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"روپیه پاکستان \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دینار عراق \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"پوند سوریه\",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"افغانی \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"کرون دانمارک \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"کرون سوئد \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"کرون نروژ \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"ریال عربستان \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"ریال قطر \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"ریال عمان \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دینار کویت \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دینار بحرین \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"رینگیت مالزی \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"بات تایلند \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"دلار هنگ کنگ \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"روبل روسیه \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"منات آذربایجان \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        },\r\n        {\r\n            \"name\": \"درام ارمنستان \",\r\n            \"price\": null,\r\n            \"change\": null,\r\n            \"percent\": 0,\r\n            \"low\": null,\r\n            \"High\": null,\r\n            \"update\": null\r\n        }\r\n    ]";
                //var ArzHa = JsonConvert.DeserializeObject<List<ArzClass>>(result);
                //foreach (var arz in ArzHa)
                //{
                //    listBox1.Items.Add($"نام ارز : {arz.name} | قیمت ارز : {arz.price} | میزان تغییر :{arz.change}");
                //}

                var result = client.GetStringAsync(URl).Result;
                var Users = JsonConvert.DeserializeObject<List<User>>(result);
                listBox1.Items.Add($" user id |  user firstName  |  user lastName ");

                foreach (var user in Users)
                {
                    listBox1.Items.Add($"{user.id} |{user.firstName} |{user.lastName}");
                }
            }
        }


        class ArzClass
        {
            public string? name { get; set; }
            public string? price { get; set; }
            public string? change { get; set; }
            public string? percent { get; set; }
        }

        public class User
        {
            public int id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string countryCode { get; set; }
            public int companyId { get; set; }
        }
    }
}
