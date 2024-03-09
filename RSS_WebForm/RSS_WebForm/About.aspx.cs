using System;
using SimpleFeedReader;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using System.Text;

namespace rss_webapp
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Create an instance of the feed reader
            var reader = new FeedReader();

            //var link = "https://www.infoworld.com/category/security/index.rss";
            var link = TextBox1.Text;

            // Read a syndication feed
            var feed = reader.RetrieveFeed(link);

            string contectionString = @"Data Source=.; Initial Catalog=RSS_DB; Integrated Security=True;TrustServerCertificate=True; Pooling = False";
            using (SqlConnection con = new SqlConnection(contectionString))
            {
                con.Open();
                foreach (var item in feed)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [RSS_DB].[dbo].[RSS_TB] VALUES (@val1, @val2)", con);
                    cmd.Parameters.AddWithValue("@val1", item.Title);
                    cmd.Parameters.AddWithValue("@val2", item.Summary);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var link = TextBox1.Text;

            string cnn = @"Data Source=.; Initial Catalog=RSS_DB; Integrated Security=True;TrustServerCertificate=True; Pooling = False";
            var select = "SELECT * FROM [RSS_DB].[dbo].[RSS_TB]";
                var dataAdapter = new SqlDataAdapter(select, cnn);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();   
            
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            XDocument rssfeedxml;

            var link = TextBox1.Text;
            rssfeedxml = XDocument.Load(link);


            var rss_list = (from descendant in rssfeedxml.Descendants("item")
                        select new RssNews
                        {
                            tit = descendant.Element("title").Value,
                            desc = descendant.Element("description").Value,
                            contentlink = descendant.Element("link").Value,
                            date = descendant.Element("pubDate").Value
                        }).ToList();

            string contectionString = @"Data Source=.; Initial Catalog=RSS_DB; Integrated Security=True;TrustServerCertificate=True; Pooling = False";

            using (SqlConnection con = new SqlConnection(contectionString))
            {
                con.Open();
                foreach (var item in rss_list)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [RSS_DB].[dbo].[RSS_TB] VALUES (@val1, @val2)", con);
                    cmd.Parameters.AddWithValue("@val1", item.tit);
                    cmd.Parameters.AddWithValue("@val2", item.desc);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}