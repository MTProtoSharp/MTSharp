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

namespace MTSharp.Schema.TL.Requests.Upload
{
    [MTObject(0x4da54231)]
    public class TLGetCdnFileHashes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4da54231;
            }
        }

		[MTParameter(Order = 0)]
		public byte[] FileToken { get; set; }
		[MTParameter(Order = 1)]
		public int Offset { get; set; }


    }
}
