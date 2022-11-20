using UnityEngine;
using TMPro;
using StressLevelZero.Data;
using StressLevelZero.SFX;

namespace StressLevelZero.Interaction
{
	public class BoardGenerator : MonoBehaviour
	{
		public float boardDurability;
		[SerializeField]
		private TMP_Text durabilityText;
		[SerializeField]
		private bool isUsingAmmo;
		[SerializeField]
		private Transform FirePoint;
		[SerializeField]
		private float RaycastDistance;
		[SerializeField]
		private float breakforce;
		[SerializeField]
		private Material LineMaterial;
		[SerializeField]
		private SpawnableObject BoardObject;
		[SerializeField]
		private float distance;
		[SerializeField]
		private LayerMask layerMask;
		[SerializeField]
		private Color successColor;
		[SerializeField]
		private Color failColor;
		[SerializeField]
		private GameObject laserPointerObj;
		[SerializeField]
		private Grip _grip;
		[SerializeField]
		private GravGunSFX sfx;
	}
}
