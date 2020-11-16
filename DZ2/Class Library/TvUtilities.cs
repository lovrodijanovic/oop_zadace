using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary1
{
    public class TvUtilities
    {
		public static Episode Parse(string episodes)
		{
			string[] words = episodes.Split(',');

			int viewers = int.Parse(words[0]);
			double sumOfScores = double.Parse(words[1]);
			double maxScore = double.Parse(words[2]);
			int episode = int.Parse(words[3]);
			TimeSpan duration = TimeSpan.Parse(words[4]);
			string EpisodeName = words[5];

			Description description = new Description(episode, duration, EpisodeName);

			return new Episode(viewers, sumOfScores, maxScore, description);

		}

		public static void Sort(Episode[] episodes)
		{ 
			for(int i = 0; i < episodes.Length - 1; i++)
			{
				for(int j = 0; j < episodes.Length - i - 1; j++)
				{
					if(episodes[j] < episodes[j + 1])
					{

						Episode temp = episodes[j];
						episodes[j] = episodes[j + 1];
						episodes[j + 1] = temp;
					}
				}
			}
		}

		public double GenerateRandomScore()
		{
			Random random = new Random();
			double v = random.NextDouble() * 10;

			return Math.Round(v, 5);
		}

	}
}
