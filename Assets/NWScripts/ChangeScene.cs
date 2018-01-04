using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour, IInputClickHandler
{
    public string gameScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Changing Scene");
        SceneManager.LoadScene(gameScene);
    }
}
