using System;
using UnityEngine;

public struct LadderInfo
{
	public enum Source
	{
		LEFTHAND = 0,
		RIGHTHAND = 1,
		FEET = 2,
	}

	public Source source;
	public Transform rungTransform;
	public int totalRungs;
	public int rungNumber;
	public float rungWidth;
	public float rungRadius;
}
