using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class RockThrowManager : MonoBehaviour
	{
		public Sprite groundExplode01;
		public Sprite groundExplode02;
		public Sprite[] rocks;
		public Sprite rockExplode;
		public Image explodeImage;
		public Image rockImage;
		public AudioClip rockSmashClip;
		public HoverJunkersChannel myChannel;
	}
}
