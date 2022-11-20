using UnityEngine.UI;
using UnityEngine;

namespace StressLevelZero.DuckSeason
{
	public class TripleTigerGameChannel : TelevisionChannel
	{
		public NinjaSpriteManager blackNinja;
		public NinjaSpriteManager redNinja;
		public NinjaSpriteManager goldNinja;
		public NinjaSpriteManager tigerNinja;
		public NinjaSpriteManager whiteNinja;
		public NinjaSpriteManager[] tigerNinjaShadows;
		public NinjaSpriteManager[] tigerNinjaEyesShadows;
		public NinjaSpriteManager blackNinjaStory;
		public NinjaSpriteManager redNinjaStory;
		public NinjaSpriteManager goldNinjaStory;
		public NinjaSpriteManager tigerNinjaStory;
		public Image blankImage;
		public Image titleBackgroundImage;
		public Image titleTripleImage;
		public Image titleTigerImage;
		public Image titleSmallEyesImage;
		public Image titleBigEyesImage;
		public Image controlPunchImage;
		public Image controlArrowFirstImage;
		public Image controlArrowBodyFirstImage;
		public Image controlLowKickImage;
		public Image controlArrowSecondImage;
		public Image controlArrowBodySecondImage;
		public Image controlHighKickImage;
		public Image controlArrowThirdImage;
		public Image controlArrowBodyThirdImage;
		public Image controlEyesImage;
		public Image storyFlashCard;
		public Image storyBackgroundCard;
		public Image fightMoveBarImage;
		public Image fightTimerBarimage;
		public Image fightBlackHealthImage;
		public Image fightWhiteHealthImage;
		public Image fightWhiteWin1;
		public Image fightWhiteWin2;
		public Image fightBlackWin1;
		public Image fightBlackWin2;
		public Image fightFlashImage;
		public Text shootToStartText;
		public Text roundText;
		public Text enemyText;
		public Text storyNameText;
		public Text storyQuoteText;
		public Transform titleCardTransform;
		public Transform startTextTransform;
		public Transform titleSmallEyesTransform;
		public Transform controlCardTransform;
		public Transform fightCardTransform;
		public Transform storyCardTransform;
		public AudioClip tripleTigerClip;
		public AudioClip tigerRoarClip;
		public AudioClip explosionClip;
		public AudioClip musicClip;
		public AudioClip selectClip;
		public AudioClip deathClip;
		public AudioClip youWinClip;
		public AudioClip youLoseClip;
		public AudioClip punchThunderClip;
		public AudioClip lowKickThunderClip;
		public AudioClip highKickThunderClip;
		public AudioClip thunderClip;
		public AudioClip punchClip;
		public AudioClip happyMusicClip;
		public AudioClip sadMusicClip;
		public AudioClip readyClip;
		public AudioClip fightClip;
		public AudioClip tickTockClip;
	}
}
