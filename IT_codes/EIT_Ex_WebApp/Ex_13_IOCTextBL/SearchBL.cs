using Ex_13_IOCTextCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Ex_13_IOCTextBL
{
    public class SearchBL : ISearchBL
    {

        private UnityManager _unityManager;

        public UnityManager _UnityManager
        {
            get
            {
                if (_unityManager == null)
                    _unityManager = new UnityManager();

                return _unityManager;
            }
            set { _unityManager = value; }
        }
        public List<SearchAutoCompleteObject> GetSearchResult(string text)
        {
            List<SearchAutoCompleteObject> resultList = new List<SearchAutoCompleteObject>();
            string[] searchWords = text.Split(' ');
            string query = "";

            foreach (ISearchable obj in _UnityManager.Container.ResolveAll<ISearchable>())
            {
                query += obj.GetSearchQuery(searchWords);
                if (query != "")
                    query += " union ";
            }

            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["TextIOCConnectionString"].ConnectionString))
            {
                try
                {
                    query = query.Substring(0, query.Length - 7);
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Prepare();

                    foreach (string word in searchWords)
                        for (int i = 1; i <= 4; i++)
                            command.Parameters.AddWithValue("@p" + i.ToString(), word);

                    SqlDataAdapter da = new SqlDataAdapter();
                    connection.Open();
                    da.SelectCommand = command;
                    da.Fill(dt);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }

            }
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SearchAutoCompleteObject searchObject = new SearchAutoCompleteObject();
                    searchObject.Col1 = dr["Col1"].ToString();
                    searchObject.Col2 = dr["Col2"].ToString();
                    searchObject.Col3 = dr["Col3"].ToString();
                    searchObject.Entity = dr["Entity"].ToString();
                    resultList.Add(searchObject);
                }
            }
            return resultList;
        }

    }
    public class SearchAutoCompleteObject
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Entity { get; set; }

    }
}