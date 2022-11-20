using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class GhoulsControl : TelevisionChannel
	{
		public GameObject titleObject;
		public GameObject gamePlayObject;
		public GameObject gameOverObject;
		public GameObject gameWinObject;
		public GameObject heart_A;
		public GameObject heart_B;
		public GameObject heart_C;
		public GameObject playerHurt;
		public GameObject storyScenesPanel;
		public GameObject backgroundCastle;
		public GameObject backgroundThrone;
		public GameObject backgroundCampfire;
		public GameObject backgroundGateways;
		public GameObject gatewayOpen;
		public GameObject gatewayClosed;
		public GameObject treasureBox;
		public GameObject overlayTextDisplay;
		public GameObject buttonYes;
		public GameObject buttonNo;
		public Image knightImage;
		public Image ghoulImage;
		public Image background;
		public AudioClip clip_enemyAttk;
		public AudioClip clip_playerAttk;
		public AudioClip loopClip;
		public AudioClip clip_textblip;
		public AudioClip clip_windBlowing;
		public AudioClip clip_keyNoise;
		public AudioClip clip_campfire;
		public AudioClip clip_creepyTalking;
		public AudioClip clip_doorOpen;
		public AudioClip clip_meetTheKing;
		public AudioClip clip_winSong;
		public AudioClip clip_loseSong;
		public AudioClip clip_enemySplat;
		public Sprite ghoulSprite;
		public Sprite ghoulDarkSprite;
		public Sprite ghoulSplat;
		public Animator knightAnimator;
		public Text scoreText;
		public Text scoreTextTitle;
		public Text dialogueText;
		public int messageInt;
		public string currentMessage;
	}
}
