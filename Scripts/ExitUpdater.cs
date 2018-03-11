using UnityEngine;
using System.Collections;

namespace DSA.Extensions.Exits
{
	public class ExitUpdater : MonoBehaviour
	{

		public string[] sceneNamesCopy;
		public Exit exit;

		public void GetSceneNames()
		{
			exit = GetComponent<Exit>();
			//Replace below code with SceneGlobals
			/*sceneNamesCopy = new string[GameSceneManager.Instance.SceneNames.Length];
			for (int i = 0; i < GameSceneManager.Instance.SceneNames.Length; i++)
			{
				sceneNamesCopy[i] = GameSceneManager.Instance.SceneNames[i];
			}*/
		}


	}
}