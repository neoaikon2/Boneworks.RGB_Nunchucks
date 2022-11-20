using UnityEngine.UI;
using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class DuckDropOffChannel : TelevisionChannel
	{
		public Text ducksText;
		public Text scoreText;
		public Text totalText;
		public int ducksDropped;
		public int levelScore;
		public int totalScore;
		public AudioClip duckPumpClip;
		public AudioClip duckTruckStopClip;
		public AudioClip duckTruckGoClip;
		public AudioClip duckPipeGrowClip;
		public AudioClip duckPipeShrinkClip;
	}
}
