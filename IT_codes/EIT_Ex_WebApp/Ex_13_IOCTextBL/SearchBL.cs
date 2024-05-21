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
    public class SearchBL: ISearchBL
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
        public List<SearchAoutoCompleteObject> GetSearchResult(string text)
        {
            List<SearchAoutoCompleteObject> resultList = new List<SearchAoutoCompleteObject>();
            string[] searchWords = text.Split(' ');
            string query = "";
            foreach (ISearchable obj in _UnityManager.Container.ResolveAll<ISearchable>())
            {
                query = obj.GetSearchQuery(searchWords);
                if (query != "")
                    query += " union ";
            }       
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(""))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    for(int i = 0;i< searchWords.Length;i++)
                        command.Parameters.AddWithValue("@p" + i, searchWords[i]);
                    SqlDataAdapter da = new SqlDataAdapter();
                    connection.Open();
                    da.Fill(dt);
                }
                catch(Exception ex)
                {
                    return null;
                }
                finally 
                {
                    connection.Close();
                }
                
            }
            if(dt!=null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SearchAoutoCompleteObject searchObject = new SearchAoutoCompleteObject();
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
    public class SearchAoutoCompleteObject
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Entity { get; set; }

    }
}
