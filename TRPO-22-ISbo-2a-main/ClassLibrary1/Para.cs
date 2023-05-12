using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Para
    {
        public Smena Smena { get; }
        public DateTime TheStartTimeOfThePair { get; }
        public DateTime TheEndTimeOfThePair { get; }
        public DateTime BreakStartTime { get; }
        public DateTime BreakEndTime { get; }
        public Para(DateTime theStartTimeOfThePair, DateTime theEndTimeOfThePair, DateTime breakStartTime, DateTime breakEndTime, Smena smena)
        {
            TheStartTimeOfThePair = theStartTimeOfThePair;
            TheEndTimeOfThePair = theEndTimeOfThePair;
            BreakStartTime = breakStartTime;
            BreakEndTime = breakEndTime;
            Smena = smena;
        }
        public Para(Smena smena)
         : this(DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, smena)
        {

        }
    }
}
