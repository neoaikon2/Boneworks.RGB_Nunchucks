using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class HoverJunkersControl : TelevisionChannel
	{
		public GameObject TitleScreen;
		public GameObject GameScreen;
		public GameObject GameOverScreen;
		public GameObject defense_A;
		public GameObject defense_B;
		public GameObject heart_A;
		public GameObject heart_B;
		public GameObject heart_C;
		public GameObject explosion_shipA;
		public GameObject explosion_shipB;
		public GameObject characterA_shoot;
		public GameObject characterB_shoot;
		public GameObject selfHitFlash;
		public RectTransform shipAObject;
		public RectTransform shipBObject;
		public Image sandScroller;
		public Image rockScroller;
		public Image shipABody;
		public Image shipBBody;
		public Image characterA;
		public Image characterB;
		public Image shipA_junkA;
		public Image shipA_junkB;
		public Image shipB_junkA;
		public Image shipB_junkB;
		public Image muzzleFlash_hit;
		public Sprite[] sprite_Ship;
		public Sprite[] sprite_Junk;
		public Sprite sprite_char_human;
		public Sprite sprite_char_humanCrouch;
		public Sprite sprite_char_humanDie;
		public Sprite sprite_char_robot;
		public Sprite sprite_char_robotCrouch;
		public Sprite sprite_char_robotDie;
		public Text scoreText;
		public Text scoreTxtHeader;
		public AudioClip clip_enemyHit;
		public AudioClip clip_enemyExplodes;
		public AudioClip clip_enemyStandsUp;
		public AudioClip clip_enemyShoots;
		public AudioClip clip_junkBreaks;
		public AudioClip clip_playerHit;
		public AudioClip clip_gameOver;
		public AudioClip clip_pressStart;
		public AudioClip clip_menuMusic;
	}
}
