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

namespace MTSharp.Schema.TL.Requests.Payments
{
    [MTObject(0x227d824b)]
    public class TLGetSavedInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x227d824b;
            }
        }



    }
}
