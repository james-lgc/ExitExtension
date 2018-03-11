using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using DSA.Extensions.Base;

[RequireComponent(typeof(TraitedMonoBehaviour))]
[System.Serializable]
public abstract class ExitTrait : TraitBase
{
	public override ExtensionEnum.Extension Extension { get { return ExtensionEnum.Extension.Exit; } }
}
