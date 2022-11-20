using UnityEngine;
using TMPro;
using UnityEngine.UI;
using StressLevelZero.Data;

namespace StressLevelZero.UI.Radial
{
	public class SpawnablesPanelView : PanelView
	{
		public GameObject[] items;
		public GameObject[] catItems;
		public GameObject[] tabItems;
		public TextMeshPro[] text;
		public TextMeshPro[] catText;
		public RawImage[] itemBackgrounds;
		public RawImage[] catItemBackgrounds;
		public RawImage[] tabImageBackgrounds;
		public GameObject spawnSelectPage;
		public GameObject utilitySelectPage;
		public GameObject forwardButton;
		public GameObject backButton;
		public TextMeshPro pageText;
		public SpawnableObject selectedObject;
	}
}
