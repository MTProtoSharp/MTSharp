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
    [MTObject(0x78337739)]
    public class TLReorderStickerSets : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x78337739;
            }
        }

		[MTParameter(Order = 0, IsFlag = true)]
		public int Flags { get; set; }
		[MTParameter(Order = 1, FlagBitId=0, FlagType= FlagType.True)]
		public bool Masks { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<long> Order { get; set; }


    }
}
