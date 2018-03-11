using UnityEngine;
using System.Collections;

namespace DSA.Extensions.Exits
{
	[System.Serializable]
	public class ExitLockArray
	{
		public Exit sceneExit;
		public bool startUnlocked;
		public int[] stageChanges;
	}
}
