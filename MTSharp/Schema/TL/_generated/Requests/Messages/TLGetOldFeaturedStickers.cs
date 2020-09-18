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

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x5fe7025b)]
    public class TLGetOldFeaturedStickers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x5fe7025b;
            }
        }

		[MTParameter(Order = 0)]
		public int Offset { get; set; }
		[MTParameter(Order = 1)]
		public int Limit { get; set; }
		[MTParameter(Order = 2)]
		public int Hash { get; set; }


    }
}
