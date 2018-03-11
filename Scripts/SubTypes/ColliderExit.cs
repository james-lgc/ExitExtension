using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

namespace DSA.Extensions.Exits
{
	public class ColliderExit : Exit
	{
		public void OnTriggerEnter()
		{
			if (!GetIsExtensionLoaded()) return;
			Use();
		}
	}
}