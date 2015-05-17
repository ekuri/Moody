using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moody
{
    class SingleMoodRecord
    {
        public string dateTime { set; get; }
        public int moodScore { set; get; }
        public string moodImage { set; get; }
        public string moodDescription { set; get; }

        public SingleMoodRecord(string dateTime, int moodScore, string moodImage, string moodDescription = "")
        {
            this.dateTime = dateTime;
            this.moodScore = moodScore;
            this.moodImage = moodImage;
            this.moodDescription = moodDescription;
        }
    }
}
