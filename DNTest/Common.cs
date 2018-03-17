using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Data;
using System.Reflection;

namespace DNTest.Entity
{
   public static class Common
    {

        public static string topicID;
        public static string topicName;
        public static string topic_subjectID;
        public static string subjectID;
        public static string subjectName;
        public static string subject_facultyID;
        //-----------
        public static string permuteStyle="-1";
        public static SortedSet<Question> lstDsCauHoiDaChon = new SortedSet<Question>();

        public static SortedDictionary<string, Question> lstDsCauHoiTrongDeThi = new SortedDictionary<string, Question>();

        //
        public static DataTable ConverSortedtListToDataTable<T> (SortedSet<T> lst)
        {
            DataTable dt = new DataTable(typeof(T).Name);
            //get all properties
            PropertyInfo[] Pros = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Pros)
            {
                //set col names as property names
                dt.Columns.Add(prop.Name);

            }

            foreach (T item in lst)
            {
                var values = new object[Pros.Length];
                for(int i=0; i<Pros.Length; i++)
                {
                    //insert property values to datatable rows
                    values[i] = Pros[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }

            return dt;
        }

        public static DataTable ConvertListToDataTable<T>(List<T> lst)
        {
            DataTable dt = new DataTable(typeof(T).Name);
            //get all properties
            PropertyInfo[] Pros = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Pros)
            {
                //set col names as property names
                dt.Columns.Add(prop.Name);

            }

            foreach (T item in lst)
            {
                var values = new object[Pros.Length];
                for (int i = 0; i < Pros.Length; i++)
                {
                    //insert property values to datatable rows
                    values[i] = Pros[i].GetValue(item, null);
                }
                dt.Rows.Add(values);
            }

            return dt;
        }


        //convert text to image png
        public static void DrawText(string text, int maxWidth, String path)
        {
            Font font = new Font("Arial", 25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);
            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font, maxWidth);

            //set the stringformat flags to rtl
            StringFormat sf = new StringFormat();
            //uncomment the next line for right to left languages
            //sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            sf.Trimming = StringTrimming.Word;
            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);
            //Adjust for high quality
            drawing.CompositingQuality = CompositingQuality.HighQuality;
            drawing.InterpolationMode = InterpolationMode.HighQualityBilinear;
            drawing.PixelOffsetMode = PixelOffsetMode.HighQuality;
            drawing.SmoothingMode = SmoothingMode.HighQuality;
            drawing.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            //paint the background
            drawing.Clear(Color.Transparent);

            Color textColor = Color.Black;
            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, new RectangleF(0, 0, textSize.Width, textSize.Height), sf);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();
            img.Save(path, ImageFormat.Png);
            img.Dispose();

        }

    }
}
