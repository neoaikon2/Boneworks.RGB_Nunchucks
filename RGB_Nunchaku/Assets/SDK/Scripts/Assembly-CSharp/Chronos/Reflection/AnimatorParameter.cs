using System;
using UnityEngine;

namespace Chronos.Reflection
{
	[Serializable]
	public class AnimatorParameter
	{
		[SerializeField]
		private Animator _target;
		[SerializeField]
		private string _name;
	}
}
