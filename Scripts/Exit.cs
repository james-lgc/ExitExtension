using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using DSA.Extensions.Base;

//Each exit should have an int to contorl spawn point if multiple exits.

namespace DSA.Extensions.Exits
{
	[System.Serializable]
	public abstract class Exit : TraitedMonoBehaviour, ISendable<Exit>, IUseable
	{
		public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Exit; } }

		[SerializeField] private string exitName;
		public string ExitName { get { return exitName; } }

		[Header("Locks")]
		[SerializeField]
		private LockBarrier barrier;
		public LockBarrier Barrier
		{
			get
			{
				if (barrier == null) barrier = GetComponent<LockBarrier>();
				return barrier;
			}
			private set { barrier.Set(value); }
		}
		[SerializeField] protected bool isLocked;
		public bool IsLocked { get { return isLocked; } private set { return; } }
		[SerializeField] protected bool startLocked;
		public bool StartLocked { get { return startLocked; } private set { return; } }

		public Action<Exit> SendAction { get; set; }

		[SerializeField] protected LockCondition[] lockConditions;

		private void Awake()
		{
			if (barrier != null)
			{
				barrier.Exit = this;
			}
		}

		public virtual void Use()
		{
			if (SendAction == null) { return; }
			SendAction(this);
		}

		public void SetActive()
		{
			CallInSequence(0);
		}
	}
}
