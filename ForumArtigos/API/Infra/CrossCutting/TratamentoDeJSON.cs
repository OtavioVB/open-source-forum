using System.Data;
using System.Text;

namespace API.Infra.CrossCutting
{
    public static class TratamentoDeJSON
    {
        public static string CONVERTER_DATATABLE_PARA_JSON_LIST(DataTable Data)
        {
            StringBuilder JSON = new StringBuilder();
            if (Data != null)
            {
                if (Data.Rows.Count > 0)
                {
                    JSON.Append("[");
                    for (int i = 0; i < Data.Rows.Count; i++)
                    {
                        JSON.Append("{");
                        for (int k = 0; k < Data.Columns.Count; k++)
                        {
                            if (k < Data.Columns.Count - 1)
                            {
                                JSON.Append("\"" + Data.Columns[k].ColumnName.ToString() + "\":" + "\"" + Data.Rows[i][k].ToString() + "\",");
                            }
                            else if (k == Data.Columns.Count - 1)
                            {
                                JSON.Append("\"" + Data.Columns[k].ColumnName.ToString() + "\":" + "\"" + Data.Rows[i][k].ToString() + "\"");
                            }
                        }
                        if (i == Data.Rows.Count - 1)
                        {
                            JSON.Append("}");
                        }
                        else
                        {
                            JSON.Append("},");
                        }
                    }
                    JSON.Append("]");
                }

                return JSON.ToString();
            }

            return "";
        }

        public static string CONVERTER_DATATABLE_PARA_JSON_OBJECT(DataTable Data)
        {
            StringBuilder JSON = new StringBuilder();
            if (Data != null)
            {
                if (Data.Rows.Count == 1)
                {
                    JSON.Append("{");
                    for (int k = 0; k < Data.Columns.Count; k++)
                    {
                        if (k < Data.Columns.Count - 1)
                        {
                            JSON.Append("\"" + Data.Columns[k].ColumnName.ToString() + "\":" + "\"" + Data.Rows[0][k].ToString() + "\",");
                        }
                        else if (k == Data.Columns.Count - 1)
                        {
                            JSON.Append("\"" + Data.Columns[k].ColumnName.ToString() + "\":" + "\"" + Data.Rows[0][k].ToString() + "\"");
                        }
                    }
                    JSON.Append("}");
                }
                return JSON.ToString();
            }

            return "";
        }
    }
}
