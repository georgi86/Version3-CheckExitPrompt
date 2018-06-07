using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExitPromptText
{
     class PositiveResult
    {
        public static void PositiveText(string ExpectedText)                                      
        {
            Ranorex.Report.Success("Sucessfully Performed: ", ExpectedText);
        }
    }

    class NegativeResult
    {
        public static void NegativeText(string ExpextedText, string Actual)
        {
            Ranorex.Report.Error("STOP THE VERSION: ", Actual);
            Ranorex.Report.Error("EXPEXTED TEXT IS: ", ExpextedText);
        }
    }
    class UtilityRun
    {
        public static void TitleText(string Actual, string Hardcoded)
        {
            string strActualText = Actual;
            string strHardcodedResult = Hardcoded;

            bool bExpectedText = true;

            bExpectedText = strActualText.CompareTo(strHardcodedResult) == 0;

            if (bExpectedText)
            {
                PositiveResult.PositiveText(Actual);
            }
            else
            {
                NegativeResult.NegativeText(Actual, Hardcoded);
            }
        }
           

    }
}
