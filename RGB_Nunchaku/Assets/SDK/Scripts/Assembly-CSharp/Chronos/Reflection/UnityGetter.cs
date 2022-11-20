using System;
using UnityEngine;

namespace Chronos.Reflection
{
	[Serializable]
	public class UnityGetter : UnityMember
	{
		[SerializeField]
		private string[] _parameterTypes;
	}
}
