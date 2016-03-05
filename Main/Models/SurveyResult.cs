using System;

namespace Main
{
    public class SurveyResult
    {
        static int lastID { get; set; }
        public int id { get; set; }
        public string answer { get; set; }

        public SurveyResult ()
        {
            id = ++lastID;
        }

        public SurveyResult (string ans)
        {
            id = ++lastID;
            answer = ans;
        }
    }
}

