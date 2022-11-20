using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class TripleTigerControl : TelevisionChannel
	{
		public GameObject titleObject;
		public GameObject gameplayObject;
		public GameObject gameWinObject;
		public GameObject gameOverObject;
		public Image wNinja;
		public Image bNinja;
		public Sprite wNinja_stand;
		public Sprite wNinja_lowKick;
		public Sprite wNinja_highKick;
		public Sprite wNinja_punch;
		public Sprite wNinja_hit;
		public Sprite wNinja_die;
		public Sprite bNinja_stand;
		public Sprite bNinja_lowKick;
		public Sprite bNinja_highKick;
		public Sprite bNinja_punch;
		public Sprite bNinja_hit;
		public Sprite bNinja_die;
		public AudioClip clip_enemyHit;
		public AudioClip clip_playerHit;
		public AudioClip clip_fall;
		public AudioClip clip_attack;
		public AudioClip loopClipA;
		public Text bNinjaHealthText;
		public Text wNinjaHealthText;
		public Text readySetGoText;
	}
}
