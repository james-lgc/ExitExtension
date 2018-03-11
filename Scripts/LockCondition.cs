using UnityEngine;
using System.Collections;

[System.Serializable]
public class LockCondition {

	[SerializeField] private int stageNum;
	[SerializeField] private bool isLocked;

	public int StageNum
	{
		get {return stageNum;}
		set {stageNum = value;}
	}

	public bool IsLocked
	{
		get {return isLocked;}
		set {isLocked = value;}
	}
}
