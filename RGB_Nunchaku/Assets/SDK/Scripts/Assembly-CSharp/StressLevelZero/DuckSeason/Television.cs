using UnityEngine.Video;

namespace StressLevelZero.DuckSeason
{
	public class Television : TelevisionBase
	{
		public enum Mode
		{
			OFF = -1,
			ALL = 0,
			NOINTRO = 1,
			MENUONLY = 2,
			VIDEOCAM = 3,
			DOGFIGHT = 4,
			FINALFIESTAENDING = 5,
			HOVERJUNKERS = 6,
			BATTLEBROS = 7,
			SINATRA = 8,
			GHOULS = 9,
			TRIPLETIGER = 10,
			WHALING = 11,
			PIZZABOY = 12,
			DOGDANCE = 13,
			DUCKFOOD = 14,
			DESSERTBOSS = 15,
		}

		public VideoClip[] defaultVideos;
		public TelevisionChannelManager cManager;
		public string defaultMovieTextureTag;
		public string gamePlusMovieTextureTag;
		public bool isDefaultMovieSkippable;
		public bool isDefaultMovieSkippableGamePlus;
		public bool LoopDefaultMovie;
		public bool isWorking;
		public VHSReciever vhsReciever;
		public Mode mode;
	}
}
