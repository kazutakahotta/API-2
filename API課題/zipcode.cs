using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API課題
{
     public class Postzip
    {
        public string status { get; set; }
        public string message { get; set; }
        public results[] results { get; set; }
       }

    public class results
    {
        public string zipcode { get; set; }
        public string prefcode { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string kana1 { get; set; }
        public string kana2 { get; set; }
        public string kana3 { get; set; }
    }

}
	