using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DSA.Extensions.Base;

namespace DSA.Extensions.Exits
{
	public class ExitManager : ManagerBase
	{
		public override ExtensionEnum Extension { get { return ExtensionEnum.Exit; } }

		private Exit[] exits;
		public Exit[] Exits { get { return exits; } }

		private Exit activeExit;
		public Exit ActiveExit { get { return activeExit; } }

		private string activeExitName;

		public override void Initialize()
		{
			base.Initialize();
			Load();
		}

		public override void Load()
		{
			base.Load();
			exits = FindObjectsOfType<Exit>();
			for (int i = 0; i < exits.Length; i++)
			{
				exits[i].SendAction = UseExit;
				RaiseTraitsFound(exits[i]);
			}
		}

		public override void LateLoad()
		{
			if (IsProcessing == false) { return; }
			for (int i = 0; i < exits.Length; i++)
			{
				if (GetIsActiveExit(exits[i])) { break; }
			}
		}

		public void UseExit(Exit sentExit)
		{
			activeExitName = sentExit.ExitName;
			QueueProecess();
		}

		public bool GetIsActiveExit(Exit sentExit)
		{
			if (sentExit.ExitName == activeExitName)
			{
				activeExit = sentExit;
				activeExit.SetActive();
				EndProcess();
				return true;
			}
			return false;
		}
	}
}