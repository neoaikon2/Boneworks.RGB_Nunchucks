using System;
using UnityEngine;

[Serializable]
public class CabletSeUp
{
	public GameObject Cable;
	public GameObject Motor;
	public Transform Parent;
	public Transform StartPoint;
	public Transform EndPoint;
	public PhysicMaterial PhysicsMaterial;
	public float velocity;
	public float gripRadius;
	public float colRadius;
	public float subdivisions;
	public Vector2 Scale;
}
