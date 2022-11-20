using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class ShipSpriteManager : MonoBehaviour
	{
		public HoverJunkersChannel myChannel;
		public AudioClip shotClip;
		public AudioClip explodeClip;
		public AudioClip bigExplosionClip;
		public ExplosionSpriteManager[] explosions;
		public ExplosionSpriteManager bigExplosion;
		public Image junkRed01Image;
		public Image junkRed02Image;
		public Image junkBlue01Image;
		public Image junkBlue02Image;
		public Image junkLong01Image;
		public Image junkLong02Image;
		public Image redCharacterImage;
		public Image blueCharacterImage;
		public Image longCharacterImage;
		public Sprite shot01;
		public Sprite shot02;
		public Image redCharacterShotImage;
		public Image blueCharacterShotImage;
		public Image longCharacterShotImage;
		public HoverJunkerCharacter[] characters;
		public Image[] redColliders;
		public Image[] blueColliders;
		public Image[] longColliders;
		public CanvasGroup shipCanvasGroup;
		public bool isDead;
		public Image shipBlueImage;
		public Image shipRedImage;
		public Image shipLongImage;
		public GameObject redShip;
		public GameObject blueShip;
		public GameObject longShip;
		public bool fromLeft;
		public bool isLongShip;
		public Sprite shottyPowerupSprite;
		public Sprite tommyPowerupSprite;
		public Sprite junkPowerupSprite;
		public Image powerUp;
	}
}
