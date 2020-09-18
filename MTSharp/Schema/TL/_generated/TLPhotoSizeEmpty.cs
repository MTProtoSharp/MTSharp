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
    [MTObject(0xe17e23c)]
    public class TLPhotoSizeEmpty : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe17e23c;
            }
        }

		[MTParameter(Order = 0)]
		public string Type { get; set; }


    }
}
