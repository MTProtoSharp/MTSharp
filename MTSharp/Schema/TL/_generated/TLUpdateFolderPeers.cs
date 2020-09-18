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
    [MTObject(0x19360dc0)]
    public class TLUpdateFolderPeers : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x19360dc0;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLFolderPeer> FolderPeers { get; set; }
		[MTParameter(Order = 1)]
		public int Pts { get; set; }
		[MTParameter(Order = 2)]
		public int PtsCount { get; set; }


    }
}
