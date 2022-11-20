using System;
using UnityEngine;

namespace Chronos.Reflection
{
	[Serializable]
	public class UnityMethod : UnityMember
	{
		[SerializeField]
		private string[] _parameterTypes;
	}
}
