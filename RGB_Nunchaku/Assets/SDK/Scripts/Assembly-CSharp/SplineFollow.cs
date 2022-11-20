using UnityEngine;

public class SplineFollow : MonoBehaviour
{
	[SerializeField]
	private Transform parent;
	[SerializeField]
	private Transform[] routes;
	[SerializeField]
	private float speedModifier;
}
