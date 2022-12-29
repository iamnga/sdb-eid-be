using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sdb_eid_be.Models
{
    public class UploadImage
    {
        public string imageBas64 { get; set; }
        public string imageType { get; set; }
    }

    public class AllInOneRequest
    {
        public string refNumber { get; set; }
        public string refDateTime { get; set; }
        public string deviceID { get; set; }
        public string sessionID { get; set; }
        public UploadImage data { get; set; }
    }
}
