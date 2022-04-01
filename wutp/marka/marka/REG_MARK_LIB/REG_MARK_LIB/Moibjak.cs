using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REG_MARK_LIB
{
    public class Moibjak
    {
        public Boolean CheckMark(String mark)
        {
            Regex regex = new Regex(@"^[АВЕКМНОРСТУХавекмнорстух]{1}[0-9]{3}(?<!0{3})[АВЕКМНОРСТУХавекмнорстух]{2}[0.1]{1}[123567]{1}[0.1-9]{1}$");
            MatchCollection matches = regex.Matches(mark);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    return true;
            }
            return false;
        }
        public String GetNextMarkAfter(String mark)
        {
            Regex regex = new Regex(@"^[АВЕКМНОРСТУХавекмнорстух]{1}[0-9]{3}(?<!0{3})[АВЕКМНОРСТУХавекмнорстух]{2}[0.1]{1}[123567]{1}[0.1-9]{1}$");            
            MatchCollection matches = regex.Matches(mark);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    return mark;
            }
            return "0-0";
        }
        public String GetNextMarkAfterRange(String prevMark, string rangeStart, string rangeEnd)
        {
            Regex regex = new Regex(@"^[АВЕКМНОРСТУХавекмнорстух]{1}[0-9]{3}(?<!0{3})[АВЕКМНОРСТУХавекмнорстух]{2}[0.1]{1}[123567]{1}[0.1-9]{1}$"); 
            MatchCollection matches = regex.Matches(prevMark);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                        return prevMark;           
            }
            return "0-0";
        }
        public int GetCombinationsCountlnRange(string mark1, string mark2)
        {
            Regex regex = new Regex(@"^[АВЕКМНОРСТУХавекмнорстух]{1}[0-9]{3}(?<!0{3})[АВЕКМНОРСТУХавекмнорстух]{2}[0.1]{1}[123567]{1}[0.1-9]{1}$");
            MatchCollection matches = regex.Matches(mark1);
            string ye = mark1.Substring(1, 3);
            int y = Convert.ToInt32(ye);
            Regex regex1 = new Regex(@"^[АВЕКМНОРСТУХавекмнорстух]{1}[0-9]{3}(?<!0{3})[АВЕКМНОРСТУХавекмнорстух]{2}[0.1]{1}[123567]{1}[0.1-9]{1}$");
            MatchCollection matches1 = regex1.Matches(mark2);
            string ey = mark2.Substring(1, 3);
            int u = Convert.ToInt32(ey);
            return u - y;
        }
    }
}
