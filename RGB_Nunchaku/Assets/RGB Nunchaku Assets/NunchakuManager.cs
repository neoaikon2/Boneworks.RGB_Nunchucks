using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.Events;
using StressLevelZero.Props.Weapons;
using System;
using ModThatIsNotMod.MonoBehaviours;
namespace NunchakuMod
{ 
    public class NunchakuManager : MonoBehaviour
    {
        public GameObject chakuPrimary = null;
        public LineRenderer lineRenderer = null;
        public GameObject chakuSecondary = null;
        public SpringJoint chakuJoint = null;

        public void DoStow() { }
        public void Unstow() { }
    }
}