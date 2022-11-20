using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class WhalingControl : TelevisionChannel
	{
		public GameObject titleScreen;
		public GameObject topScroller;
		public GameObject gameScreen;
		public GameObject winScreen;
		public GameObject loseScreen;
		public GameObject boatObject;
		public GameObject sunkBoatObject;
		public int currSpear;
		public WhalingSpear[] spears;
		public Transform startSpear;
		public bool canShoot;
		public Text spearText;
		public int totalSpearsThrown;
		public bool dead;
		public bool gameIsPlaying;
		public bool playerWon;
		public bool whalesWon;
		public int oceanSpeed;
		public Animator boatAnim;
		public GameObject[] whales;
		public GameObject[] whaleTail;
		public int currWhale;
		public bool killingThePlayer;
		public AudioClip loopClip;
		public AudioClip throwClip;
		public AudioClip hitClip;
		public AudioClip winClip;
		public AudioClip loseClip;
		public AudioClip splashClip;
		public AudioClip deathClip;
		public AudioClip seagullDeathClip;
		public LightgunChannel lightgunChannel;
	}
}
