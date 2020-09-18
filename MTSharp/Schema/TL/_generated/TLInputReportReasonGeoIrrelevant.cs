using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTSharp;
using MTSharp.Attributes;
using MTSharp.Enums;
using MTSharp.Schema;
using MTSharp.Schema.TL;

namespace MTSharp.Schema.TL
{
    [MTObject(0xdbd4feed)]
    public class TLInputReportReasonGeoIrrelevant : TLAbsReportReason
    {
        public override uint Constructor
        {
            get
            {
                return 0xdbd4feed;
            }
        }



    }
}
