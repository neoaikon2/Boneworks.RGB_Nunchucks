using UnityEngine;

namespace ch.sycoforge.Decal
{
	public class DecalBase : MonoBehaviour
	{
		[SerializeField]
		protected bool baked;
		[SerializeField]
		protected bool bakeOnAwake;
		[SerializeField]
		private bool flipNormals;
		[SerializeField]
		private bool backfaceCulling;
		[SerializeField]
		private float distance;
		[SerializeField]
		private float angleConstraint;
		[SerializeField]
		protected ProjectionTechnique technique;
		[SerializeField]
		private DeferredFlags deferredFlags;
		[SerializeField]
		private ProjectorInclusion inclusion;
		[SerializeField]
		private TransformObserver transformObserver;
	}
}
