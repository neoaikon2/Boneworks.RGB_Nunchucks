using UnityEngine;
using UnityEngine.Events;

namespace StressLevelZero.UI
{
	public class ToolTip : MonoBehaviour
	{
		public float popupTime;
		public float popdownTime;
		public bool isEditorOnly;
		public int numberOfPopups;
		public AudioClip popupClip;
		public AudioClip popdownClip;
		public UnityEvent OnFocus;
		public UnityEvent OnBlur;
	}
}
