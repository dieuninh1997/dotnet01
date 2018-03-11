using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using System.Data;
namespace DNTest
{
    class WordUtil
    {
        private Word.Application _app;
        Word.Document _doc;
        private object _pathFile;
        public WordUtil(string path, bool createApp)
        {
            _pathFile = path;
            _app = new Word.Application();
            _app.Visible = createApp;
            object ob = System.Reflection.Missing.Value;
            _doc = _app.Documents.Add(ref _pathFile, ref ob, ref ob, ref ob);
        }


        // in các mục thông qua Fiels trong word
        public void WriteFields(Dictionary<string,string> values)
        {
            foreach(Word.Field field in _doc.Fields)
            {
                string fieldName = field.Code.Text.Substring(11, field.Code.Text.IndexOf("\\") - 12).Trim();
                if (values.ContainsKey(fieldName))
                {
                    field.Select();
                    _app.Selection.TypeText(values[fieldName]);
                }
            }
        }

        //in ra bảng dữ liệu
        public void WriteTable(DataTable vDataTable, int vIndexTable)
        {
            Word.Table tbl = _doc.Tables[vIndexTable];
            int lenrow = vDataTable.Rows.Count;
            int lencol = vDataTable.Columns.Count;
            for (int i = 0; i < lenrow; ++i)
            {
                object ob = System.Reflection.Missing.Value;
                tbl.Rows.Add(ref ob);
                for (int j = 0; j < lencol; ++j)
                {
                    tbl.Cell(i + 2, j + 1).Range.Text = vDataTable.Rows[i][j].ToString();
                }
            }
        }

    }
}
