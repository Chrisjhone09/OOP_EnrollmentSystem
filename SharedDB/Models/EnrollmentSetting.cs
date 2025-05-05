using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDB.Models
{
    public class EnrollmentSetting
    {
        public int Id { get; set; }
        public bool AllowRequest { get; set; }
        public int Limit { get; set; }
        public bool AutoAccept { get; set; }
    }
}
