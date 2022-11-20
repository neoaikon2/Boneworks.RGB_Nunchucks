using UnityEngine;
using StressLevelZero.UI;
using StressLevelZero.Data;

namespace StressLevelZero.UI.Radial
{
	public class PopUpMenuView : MonoBehaviour
	{
		public PageView radialPageView;
		public ItemSlotsPanelView itemSlotsPanelView;
		public PreferencesPanelView preferencesPanelView;
		public SpawnablesPanelView spawnablesPanelView;
		public LevelsPanelView levelsPanelView;
		public SpawnableObject utilityGunSpawnable;
		public bool canFireGun;
		public PageElementView cursorStart;
		public PageElementView cursorEnd;
		public PageElementView cursorMid;
	}
}
