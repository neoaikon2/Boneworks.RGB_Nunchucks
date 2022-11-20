using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class HoverJunkersChannel : TelevisionChannel
	{
		public bool screenHasBeenShot;
		public WeaponUIManager weaponManager;
		public ShipSpriteManager ship01;
		public ShipSpriteManager ship02;
		public ShipSpriteManager ship03;
		public SandWormManager worm01;
		public AudioClip musicClip;
		public AudioClip bossMusicClip;
		public AudioClip reloadGunClip;
		public AudioClip emptyGunClip;
		public AudioClip fireGunClip;
		public AudioClip fireShotgunClip;
		public AudioClip fireTommyGunClip;
		public AudioClip junkDestroyClip;
		public Image backgroundStatic;
		public Image backgroundFar;
		public Image backgroundFarSecond;
		public Image backgroundMiddle;
		public Image backgroundMiddleSecond;
		public Image backgroundClose;
		public Image backgroundCloseSecond;
		public JunkManager leftJunk;
		public JunkManager rightJunk;
		public Image damageOverlayImage;
		public CanvasGroup hudCanvasGroup;
		public GameObject titleGameObject;
		public GameObject endGameObject;
		public GameObject winGameObject;
		public Sprite fullHeartImage;
		public Sprite emptyHeartImage;
		public Image[] hearts;
		public Animation endAnimation;
	}
}
