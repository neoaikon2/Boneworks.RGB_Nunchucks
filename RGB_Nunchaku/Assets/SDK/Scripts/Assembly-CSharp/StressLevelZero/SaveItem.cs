using UnityEngine;
using System;
using UnityEngine.Events;
using StressLevelZero.Pool;

namespace StressLevelZero
{
	public class SaveItem : MonoBehaviour
	{
		[Serializable]
		public class OnLoadItem : UnityEvent<SaveState>
		{
		}

		[SerializeField]
		private string _uuid;
		[SerializeField]
		private string _scene;
		public OnLoadItem onLoadItem;
		public Poolee poolee;
		public SaveState.Type saveType;
		public string sourceUUID;
	}
}
