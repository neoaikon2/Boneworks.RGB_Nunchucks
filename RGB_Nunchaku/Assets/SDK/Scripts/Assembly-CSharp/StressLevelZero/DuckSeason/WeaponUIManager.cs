using UnityEngine;
using UnityEngine.UI;

namespace StressLevelZero.DuckSeason
{
	public class WeaponUIManager : MonoBehaviour
	{
		public enum WeaponType
		{
			REVOVLER = 0,
			SHOTGUN = 1,
			TOMMY = 2,
		}

		public WeaponType type;
		public CanvasGroup revovler;
		public CanvasGroup shotgun;
		public CanvasGroup tommy;
		public Image[] revovlerAmmos;
		public Image[] shotgunAmmos;
		public Text tommyAmmos;
		public int ammo;
	}
}
