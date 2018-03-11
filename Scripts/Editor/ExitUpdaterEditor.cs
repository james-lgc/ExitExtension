using UnityEngine;
using System.Collections;
using UnityEditor;
using DSA.Extensions.Exits;

[CustomEditor(typeof(ExitUpdater))]
[CanEditMultipleObjects]
public class ExitUpdaterEditor : Editor
{

	private int index = 0;
	public override void OnInspectorGUI()
	{
		ExitUpdater sceneExitUpdater = (ExitUpdater)target;
		if (GUILayout.Button("GetSceneNames"))
		{
			sceneExitUpdater.GetSceneNames();
		}
		index = EditorGUILayout.Popup("Scene Name: ", index, sceneExitUpdater.sceneNamesCopy);
		if (GUILayout.Button("ChangeLinkedScene"))
		{
			//sceneExitUpdater.exit.SetSceneName(sceneExitUpdater.sceneNamesCopy[index]);
			Debug.Log("Changing Scene name (Editor)");
		}

		DrawDefaultInspector();
		if (GUILayout.Button("SetBarrier"))
		{
			//sceneExitUpdater.exit.Barrier.SetUp(sceneExitUpdater.exit.ExitDirection);
		}
	}
}
