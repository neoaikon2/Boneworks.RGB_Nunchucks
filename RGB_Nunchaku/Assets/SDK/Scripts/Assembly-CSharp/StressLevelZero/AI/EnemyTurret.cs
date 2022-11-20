using UnityEngine;
using StressLevelZero.Interaction;
using StressLevelZero.Props.Weapons;
using VLB;

namespace StressLevelZero.AI
{
	public class EnemyTurret : MonoBehaviour
	{
		public LayerMask raycastMask;
		public bool isRotateTowardsLastTargetOnJump;
		public float visionRadius;
		public float visionAngle;
		public int maxUnflipTries;
		public Color idleColor;
		public Color alertColor;
		public AITrigger trigger;
		public InteractableHost host;
		public Collider[] ignoreColliders;
		public GameObject laserPointer;
		public Transform visionPointTransform;
		public Gun gun;
		public VolumetricLightBeam volumetricLightBeam;
		public ConfigurableJoint spineSlideJnt;
		public ConfigurableJoint legRearJnt;
		public ConfigurableJoint legHingeLeftJnt;
		public ConfigurableJoint legHingeRightJnt;
		public ConfigurableJoint legLeftJnt;
		public ConfigurableJoint legRightJnt;
		public ConfigurableJoint bodyJnt;
		public ConfigurableJoint gunJnt;
		public Rigidbody bodyRB;
		public Rigidbody barrelRB;
		public Rigidbody hingeLRB;
		public Rigidbody legLRB;
		public Rigidbody hingeRRB;
		public Rigidbody legRRB;
		public Rigidbody rearSliderRB;
		public Rigidbody rearLegRB;
	}
}
