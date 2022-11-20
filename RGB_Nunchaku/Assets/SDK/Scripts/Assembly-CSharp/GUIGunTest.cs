using UnityEngine;
using System;
using StressLevelZero.Props.Weapons;

public class GUIGunTest : MonoBehaviour
{
	[Serializable]
	public struct GunStruct
	{
		public Gun gun;
		public Transform cameraTarget;
		public bool isGripped;
		public float slideValue;
		public bool isReturning;
		public bool isSlideOverride;
		public bool isSlideReleased;
	}

	public Transform camTransform;
	public GunStruct[] guns;
}
