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
    [MTObject(0x34636dd8)]
    public class TLSecureValueErrorTranslationFiles : TLAbsSecureValueError
    {
        public override uint Constructor
        {
            get
            {
                return 0x34636dd8;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsSecureValueType Type { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<byte[]> FileHash { get; set; }
		[MTParameter(Order = 2)]
		public string Text { get; set; }


    }
}
