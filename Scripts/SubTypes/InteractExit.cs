using UnityEngine;
using System.Collections;
using DSA.Extensions.Base;

namespace DSA.Extensions.Exits
{
	public class InteractExit : Exit, IInteractable
	{
		public virtual void Interact()
		{
			if (SendAction == null) { return; }
			SendAction(this);
			TraitBase[] traits = GetArray();
			for (int i = 0; i < traits.Length; i++)
			{
				if (traits[i] is IInteractCallable)
				{
					IInteractCallable interactCallable = (IInteractCallable)traits[i];
					interactCallable.CallInteract();
				}
			}
		}
	}
}
