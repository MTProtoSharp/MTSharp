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

namespace MTSharp.Schema.TL.Stats
{
    [MTObject(0xef7ff916)]
    public class TLMegagroupStats : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xef7ff916;
            }
        }

		[MTParameter(Order = 0)]
		public MTSharp.Schema.TL.TLStatsDateRangeDays Period { get; set; }
		[MTParameter(Order = 1)]
		public MTSharp.Schema.TL.TLStatsAbsValueAndPrev Members { get; set; }
		[MTParameter(Order = 2)]
		public MTSharp.Schema.TL.TLStatsAbsValueAndPrev Messages { get; set; }
		[MTParameter(Order = 3)]
		public MTSharp.Schema.TL.TLStatsAbsValueAndPrev Viewers { get; set; }
		[MTParameter(Order = 4)]
		public MTSharp.Schema.TL.TLStatsAbsValueAndPrev Posters { get; set; }
		[MTParameter(Order = 5)]
		public TLAbsStatsGraph GrowthGraph { get; set; }
		[MTParameter(Order = 6)]
		public TLAbsStatsGraph MembersGraph { get; set; }
		[MTParameter(Order = 7)]
		public TLAbsStatsGraph NewMembersBySourceGraph { get; set; }
		[MTParameter(Order = 8)]
		public TLAbsStatsGraph LanguagesGraph { get; set; }
		[MTParameter(Order = 9)]
		public TLAbsStatsGraph MessagesGraph { get; set; }
		[MTParameter(Order = 10)]
		public TLAbsStatsGraph ActionsGraph { get; set; }
		[MTParameter(Order = 11)]
		public TLAbsStatsGraph TopHoursGraph { get; set; }
		[MTParameter(Order = 12)]
		public TLAbsStatsGraph WeekdaysGraph { get; set; }
		[MTParameter(Order = 13)]
		public TLVector<MTSharp.Schema.TL.TLStatsGroupTopPoster> TopPosters { get; set; }
		[MTParameter(Order = 14)]
		public TLVector<MTSharp.Schema.TL.TLStatsGroupTopAdmin> TopAdmins { get; set; }
		[MTParameter(Order = 15)]
		public TLVector<MTSharp.Schema.TL.TLStatsGroupTopInviter> TopInviters { get; set; }
		[MTParameter(Order = 16)]
		public TLVector<TLAbsUser> Users { get; set; }


    }
}