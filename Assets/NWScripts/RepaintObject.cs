using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RepaintObject : MonoBehaviour, IInputClickHandler
{
    public Material greenMaterial;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        GetComponent<Renderer>().material = greenMaterial;
    }
}
