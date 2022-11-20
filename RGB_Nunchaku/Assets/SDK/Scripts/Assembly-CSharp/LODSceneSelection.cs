using UnityEngine;
using System;

public class LODSceneSelection : MonoBehaviour
{
	[Serializable]
	public class SceneOption
	{
		public string m_sceneName;
		public string m_sceneDisplayName;
	}

	public int BoxWidth;
	public int BoxHeight;
	public int MarginH;
	public int MarginV;
	public SceneOption[] SceneOptions;
}
