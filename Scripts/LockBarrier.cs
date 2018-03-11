using UnityEngine;
using System.Collections;

namespace DSA.Extensions.Exits
{
	[RequireComponent(typeof(BoxCollider))]
	public class LockBarrier : MonoBehaviour
	{

		protected BoxCollider col;
		public BoxCollider Collider
		{
			get { if (col == null) col = GetComponent<BoxCollider>(); return col; }
		}
		public Exit Exit { get; set; }

		public void SetUp(Vector2 exitDirection)
		{
			if (col == null)
			{
				col = GetComponent<BoxCollider>();
			}
		}

		public void Set(bool newValue)
		{
			Collider.isTrigger = !newValue;
		}

		public void Toggle()
		{
			col.isTrigger = !col.isTrigger;
		}

	}
}