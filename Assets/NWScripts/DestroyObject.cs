using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class DestroyObject : MonoBehaviour, IInputClickHandler
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Click!!!");
        Destroy(this.gameObject);
    }
}
