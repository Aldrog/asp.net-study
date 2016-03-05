using System;
using System.Collections.Generic;

namespace Main
{
    public class SurveyData
    {
        public List<SurveyResult> Data { get; set; }

        public SurveyData ()
        {
            Data = new List<SurveyResult> ();
        }
    }
}

