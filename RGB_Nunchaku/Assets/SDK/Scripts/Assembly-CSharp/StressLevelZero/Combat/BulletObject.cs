using UnityEngine;

namespace StressLevelZero.Combat
{
	[CreateAssetMenu(menuName = "Bullet Object", fileName = "New BulletObject")]
	public class BulletObject : ScriptableObject
	{
		public AmmoVariables ammoVariables;
	}
}
