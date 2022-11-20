using System.Collections.Generic;
using Chronos.Reflection;
using UnityEngine;

namespace Chronos
{
	public class CustomRecorder : Recorder<CustomRecorder.Snapshot>
	{
		public class Snapshot
		{
		}

		[SerializeField]
		private List<UnityVariable> variables;
	}
}
