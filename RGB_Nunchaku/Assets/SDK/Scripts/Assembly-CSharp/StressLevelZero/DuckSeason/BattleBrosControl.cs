using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class BattleBrosControl : TelevisionChannel
	{
		public bool jump;
		public bool running;
		public float moveForce;
		public float maxSpeed;
		public float jumpForce;
		public bool grounded;
		public Animator anim;
		public GameObject playerBroFoot;
		public int hurtTimer;
		public GameObject playerBro;
		public GameObject knight;
		public GameObject oBro;
		public GameObject yBro;
		public GameObject finishFlag;
		public GameObject highScoreScreen;
		public GameObject gameOverText;
		public GameObject deadBro;
		public Image oImage;
		public Image yImage;
		public bool clear;
		public bool restarting;
		public GameObject[] knights;
		public int prevRand;
		public int prevRandBatt;
		public GameObject[] Lances;
		public bool gameIsPlaying;
		public int score;
		public GameObject battery;
		public GameObject currBro;
		public GameObject[] batteries;
		public Text scoreText;
		public Text lifeText;
		public GameObject brickScroller;
		public GameObject cloudScroller;
		public GameObject knightScroller;
		public int maxClouds;
		public GameObject[] clouds;
		public float cloudHorizMin;
		public float CloudHorizMax;
		public float cloudVertMin;
		public float cloudVertMax;
		public GameObject scrollWorld;
		public GameObject TitleScreen;
		public GameObject GameScreen;
		public GameObject GameOverScreen;
		public GameObject WinnerScreen;
		public Vector2 broPos1;
		public Vector2 broPos2;
		public AudioClip jumpClip;
		public AudioClip backgroundLoopClip;
		public AudioClip dieClip;
		public AudioClip killClip;
		public AudioClip gameOverClip;
		public AudioClip winClip;
		public AudioClip powerClip;
		public AudioClip powerLoopClip;
		public AudioClip speedLoopClip;
		public AudioClip scoreClip;
		public AudioClip loopClip;
		public AudioClip flagWinClip;
		public AudioClip powerOverClip;
		public AudioClip fireWorksClip;
		public AudioClip titleClip;
		public AudioClip spikeClip;
		public LightgunChannel lightgunChannel;
		public float multiplier;
	}
}
