using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourIk : SubBehaviourBase
	{
		public bool footIkOn;
		public IK[] footIkSolvers;
		public Transform[] toeTrans;
		public float curWeight;
		public IK[] armIkSolvers;
		public bool armIkActiveLf;
		public bool armIkActiveRt;
		public Transform lfHandTarget;
		public Transform rtHandTarget;
		public Transform lfHandAnim;
		public Transform rtHandAnim;
		public bool isHuman;
		public Transform lfClav;
		public Transform lfAc;
		public Transform lfUpperTwist;
		public Transform lfTwist;
		public Transform lfWrist;
		public Transform lfHand;
		public Transform rtClav;
		public Transform rtAc;
		public Transform rtUpperTwist;
		public Transform rtTwist;
		public Transform rtWrist;
		public Transform rtHand;
		public Transform skinnedSpine1;
		public Transform neck1;
		public Transform neck2;
		public Transform neckTop;
		public Transform spine1;
		public Transform spine2;
		public Transform spineTop;
		public Transform neck;
		public Transform head;
		public Transform eyeL;
		public Transform eyeR;
		public int lfShoulderMuscleIndex;
		public int rtShoulderMuscleIndex;
	}
}
