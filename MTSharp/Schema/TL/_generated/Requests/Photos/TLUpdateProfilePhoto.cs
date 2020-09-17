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

namespace MTSharp.Schema.TL.Requests.Photos
{
    [MTObject(0xf0bb5152)]
    public class TLUpdateProfilePhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0bb5152;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputPhoto Id { get; set; }


    }
}