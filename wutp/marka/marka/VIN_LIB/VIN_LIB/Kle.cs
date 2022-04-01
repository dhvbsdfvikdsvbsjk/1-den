using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Kle
    {
        public Boolean CheckVIN(string vin)
        {
            Regex regex = new Regex(@"^[1-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{6}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{8}$");
            MatchCollection matches = regex.Matches(vin);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    return true;
            }
            return false;
        }
        public string GetVINCountry(string vin)
        {
            Regex regex = new Regex(@"^[1-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{6}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{8}$");
            MatchCollection matches = regex.Matches(vin);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    return vin;
            }
            return vin;
        }
        public string GetTransportYear(String vin)
        {
            Regex regex = new Regex(@"^[1-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{6}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{1}[0-9ABCDEFGHJKLMNPRSTUVWXYZ]{8}$");
            MatchCollection matches = regex.Matches(vin);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    return vin;
            }
            return vin;
        }
    }
}
