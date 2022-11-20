using UnityEngine;
using System;

public class DiscoRoom : MonoBehaviour
{
	[Serializable]
	public struct Reflections
	{
		public Color LeftWallColor;
		public Color RightWallColor;
		public Cubemap cubemap;
	}

	[SerializeField]
	private Light SideLight1;
	[SerializeField]
	private Light SideLight2;
	[SerializeField]
	private Renderer[] SideRenderer1;
	[SerializeField]
	private Renderer[] SideRenderer2;
	[SerializeField]
	private ReflectionProbe reflectionProbe;
	[SerializeField]
	public Reflections[] reflections;
}
