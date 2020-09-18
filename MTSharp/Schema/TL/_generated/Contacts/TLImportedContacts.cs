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

namespace MTSharp.Schema.TL.Contacts
{
    [MTObject(0x77d01c3b)]
    public class TLImportedContacts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x77d01c3b;
            }
        }

		[MTParameter(Order = 0)]
		public TLVector<MTSharp.Schema.TL.TLImportedContact> Imported { get; set; }
		[MTParameter(Order = 1)]
		public TLVector<MTSharp.Schema.TL.TLPopularContact> PopularInvites { get; set; }
		[MTParameter(Order = 2)]
		public TLVector<long> RetryContacts { get; set; }
		[MTParameter(Order = 3)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}
