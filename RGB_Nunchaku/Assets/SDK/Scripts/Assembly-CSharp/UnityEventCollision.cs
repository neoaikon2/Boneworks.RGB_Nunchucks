using System;
using UnityEngine.Events;
using UnityEngine;

[Serializable]
public class UnityEventCollision : UnityEvent<Collider, Vector3, Vector3>
{
}
