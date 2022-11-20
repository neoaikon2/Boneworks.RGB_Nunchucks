using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine;

public class VRPhysicsRaycaster : BaseRaycaster
{
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
	{
	}

	public override Camera eventCamera
	{
		get { return default(Camera); }
	}

	[SerializeField]
	protected LayerMask m_EventMask;
	[SerializeField]
	protected int m_MaxRayIntersections;
}
