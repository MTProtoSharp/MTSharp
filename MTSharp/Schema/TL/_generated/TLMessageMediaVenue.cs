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
    [MTObject(0x2ec0533f)]
    public class TLMessageMediaVenue : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x2ec0533f;
            }
        }

		[MTParameter(Order = 0)]
		public TLAbsGeoPoint Geo { get; set; }
		[MTParameter(Order = 1)]
		public string Title { get; set; }
		[MTParameter(Order = 2)]
		public string Address { get; set; }
		[MTParameter(Order = 3)]
		public string Provider { get; set; }
		[MTParameter(Order = 4)]
		public string VenueId { get; set; }
		[MTParameter(Order = 5)]
		public string VenueType { get; set; }


    }
}
