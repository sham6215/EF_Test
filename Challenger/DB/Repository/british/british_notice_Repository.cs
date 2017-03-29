using Challenger.Domain.DB.british;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenger.DB.Repository.british
{
    class british_notice_Repository : Repository<british_notice>
    {
        public british_notice_Repository(BritishPaper context) : base(context)
        {
        }

        override public IEnumerable<british_notice> GetAllFull()
        {
            return _Entities.ToList();
        }

        public IEnumerable<british_notice_test> GetAllFullTest()
        {
            return _Entities.Select(
                x => new british_notice_test()
                {
                    active = x.active,
                    area_id = x.area_id,
                    cancel_date = x.cancel_date,
                    chart_id = x.chart_id,
                    id = x.id,
                    number = x.number,
                    type = x.type,
                    week_notice_id = x.week_notice_id
                })
                //.Include(x => x.british_notice
                //    .Select(y => y.british_week_notice))
                //.Include(x => x.british_notice
                //    .Select(y => y.british_notice_graphic))
                .ToList();
            //.Take(100).ToList();
        }
    }
}
