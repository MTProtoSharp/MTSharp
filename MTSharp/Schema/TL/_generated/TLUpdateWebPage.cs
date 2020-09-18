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
    [MTObject(0x7f891213)]
    public class TLUpdateWebPage : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x7f891213;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsWebPage Webpage { get; set; }
		[MTParameter(Order = 1)]
		public int Pts { get; set; }
		[MTParameter(Order = 2)]
		public int PtsCount { get; set; }


    }
}
