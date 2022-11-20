using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace StressLevelZero.UI.Radial
{
	public class LevelsPanelView : PanelView
	{
		public GameObject[] items;
		public TextMeshPro[] text;
		public Image[] sceneImage;
		public Sprite[] m_SceneSprite;
		public bool useSceneImage;
		public GameObject forwardButton;
		public GameObject backButton;
		public TextMeshPro pageText;
		public int[] sceneBlacklist;
	}
}
