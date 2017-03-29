using Challenger.Domain.DB.british;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Challenger.DB.Repository.british
{
    class british_chart_Repository : Repository<british_chart>
    {
        public british_chart_Repository(BritishPaper context) : base(context)
        {
        }

        override public IEnumerable<british_chart> GetAllFull()
        {
            return _Entities
                //.Include(x => x.british_notice
                //    .Select(y => y.british_week_notice))
                //.Include(x => x.british_notice
                //    .Select(y => y.british_notice_graphic))
                .ToList();
                //.Take(100).ToList();
        }
    }
}
