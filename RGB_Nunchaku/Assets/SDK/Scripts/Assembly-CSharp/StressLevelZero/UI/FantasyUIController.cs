using UnityEngine;
using System;
using StressLevelZero.UI.Radial;

namespace StressLevelZero.UI
{
	public class FantasyUIController : MonoBehaviour
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
		public Transform menuTransform;
		public CursorRegion[] regions;
	}
}
