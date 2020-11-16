namespace ClassLibrary1
{
    public class Episode
    {

        private int viewers;
        private double sumOfScores;
        private double maxScore;
        private Description description;

        public Episode() { }

        public Episode(int viewers, double sumOfScores, double maxScore)
        {
            this.viewers = viewers;
            this.sumOfScores = sumOfScores;
            this.maxScore = maxScore;
            viewers = 0;
            sumOfScores = 0;
            maxScore = 0;
        }

        public Episode(int viewers, double sumOfScores, double maxScore, Description description)
        {
            this.viewers = viewers;
            this.sumOfScores = sumOfScores;
            this.maxScore = maxScore;
            this.description = description;
            viewers = 0;
            sumOfScores = 0;
            maxScore = 0;
        }
        public void AddView(double score)
        {
            viewers++;
            sumOfScores += score;

            if (score > maxScore) maxScore = score;
        }

        public int GetViewerCount()
        {
            return viewers;
        }
        
        public double GetAverageScore()
        {
            return sumOfScores/viewers;
        }

        public double GetMaxScore()
        {
            return maxScore;
        }

        public override string ToString()
        {
            return $"{viewers},{sumOfScores},{maxScore},{description}";
        }

        public static bool operator <(Episode ep1, Episode ep2)
        {
            if (ep1.GetAverageScore() < ep2.GetAverageScore())
                return true;
            else return false;
        }
        public static bool operator >(Episode ep1, Episode ep2)
        {
            if (ep1.GetMaxScore() > ep2.GetMaxScore())
                return true;
            else return false;
        }
    }
}
