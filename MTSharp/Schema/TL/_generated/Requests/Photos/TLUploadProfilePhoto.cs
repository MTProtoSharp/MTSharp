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
    [MTObject(0x4f32c098)]
    public class TLUploadProfilePhoto : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4f32c098;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsInputFile File { get; set; }


    }
}
