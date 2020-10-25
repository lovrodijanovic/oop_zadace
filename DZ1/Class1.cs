using System;
using System.Dynamic;

namespace ClassLibrary1
{
    public class Episode
    {

        private int viewers = 0;

        private double sumOfScores = 0;

        private double maxScore = 0;


        public Episode() { }

        public Episode(int viewers, double sumOfScores, double maxScore)
        {
            this.viewers = viewers;
            this.sumOfScores = sumOfScores;
            this.maxScore = maxScore;
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
            return sumOfScores/(double)viewers;
        }

        public double GetMaxScore()
        {
            return maxScore;
        }
    }
}
