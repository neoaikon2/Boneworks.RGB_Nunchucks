using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class VRGraphicRaycaster : BaseRaycaster
{
	public enum BlockingObjects
	{
		None = 0,
		TwoD = 1,
		ThreeD = 2,
		All = 3,
	}

	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	public override Camera eventCamera
	{
		get { return default(Camera); }
	}

	public Camera eventCameraOverride;
	[SerializeField]
	private bool m_IgnoreReversedGraphics;
	[SerializeField]
	private BlockingObjects m_BlockingObjects;
	[SerializeField]
	protected LayerMask m_BlockingMask;
}
