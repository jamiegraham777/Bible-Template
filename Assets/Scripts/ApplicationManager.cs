using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {

   
    public void LoadScene(string level)
    {
        Application.LoadLevel(level);
    }

    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
