using UnityEngine;
using System;
using StressLevelZero.UI.Radial;

namespace StressLevelZero.UI
{
	public class MainMenuUIController : MonoBehaviour
	{
		[Serializable]
		public struct CursorRegion
		{
			public Transform center;
			public Bounds bounds;
		}

		public PageElementView cursorStart;
		public PageElementView cursorEnd;
		public PageElementView cursorMid;
		public LineRenderer cursorLine;
		public CursorRegion[] regions;
	}
}
