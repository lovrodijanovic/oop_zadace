using System;

namespace ClassLibrary1
{
    public class Description
    {
        private int episode;
        private TimeSpan duration;
        private string EpisodeName;

        public Description(int episode, TimeSpan duration, string EpisodeName)
        {
            this.episode = episode;
            this.duration = duration;
            this.EpisodeName = EpisodeName;
        }

        public override string ToString()
        {
            return $"{episode},{duration},{EpisodeName}";
        }
    }
}
