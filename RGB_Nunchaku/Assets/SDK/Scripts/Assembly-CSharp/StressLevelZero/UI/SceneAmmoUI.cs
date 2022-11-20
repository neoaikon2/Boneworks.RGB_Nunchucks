using UnityEngine;
using System;
using TMPro;

namespace StressLevelZero.UI
{
	public class SceneAmmoUI : MonoBehaviour
	{
		[Serializable]
		public struct SceneNames
		{
			public string prettyName;
			public string fileName;
		}

		[Serializable]
		public struct TextFields
		{
			[SerializeField]
			public TextMeshProUGUI name;
			[SerializeField]
			public TextMeshProUGUI count;
		}

		//public Data_Manager dataManager;
		public SceneNames[] scenesToList;
		public TextFields[] references;
	}
}
