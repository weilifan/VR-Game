using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinUIManager : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(false);
    }
	
    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
	
	public void Exit()
    {
        #if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
    }
}
