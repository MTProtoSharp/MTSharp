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
    [MTObject(0xf9c8bcc6)]
    public class TLWebDocumentNoProxy : TLAbsWebDocument
    {
        public override uint Constructor
        {
            get
            {
                return 0xf9c8bcc6;
            }
        }

		[MTParameter(Order = 0)]
		public string Url { get; set; }
		[MTParameter(Order = 1)]
		public int Size { get; set; }
		[MTParameter(Order = 2)]
		public string MimeType { get; set; }
		[MTParameter(Order = 3)]
		public TLVector<TLAbsDocumentAttribute> Attributes { get; set; }


    }
}
