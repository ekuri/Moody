using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moody
{
    class SimgleMoodRecord
    {
        public string dateTime { set; get; }
        public int moodScore { set; get; }
        public string moodImage { set; get; }

        public SimgleMoodRecord(string dateTime, int moodScore, string moodImage)
        {
            this.dateTime = dateTime;
            this.moodScore = moodScore;
            this.moodImage = moodImage;
        }
    }
}
