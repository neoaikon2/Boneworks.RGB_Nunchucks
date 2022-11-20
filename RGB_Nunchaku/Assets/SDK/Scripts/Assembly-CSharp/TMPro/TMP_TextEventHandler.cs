using UnityEngine;
using System;
using UnityEngine.Events;

namespace TMPro
{
	public class TMP_TextEventHandler : MonoBehaviour
	{
		[Serializable]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
		}

		[Serializable]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
		}

		[Serializable]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
		}

		[Serializable]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
		}

		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;
	}
}
