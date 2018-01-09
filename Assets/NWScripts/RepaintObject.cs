using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RepaintObject : MonoBehaviour, IInputClickHandler
{
    public Material repaintedMaterial;
    private Material originalMaterial;
    private bool isRepainted;

	// Use this for initialization
	void Start () {
        originalMaterial = GetComponent<Renderer>().material;
        isRepainted = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        var newMaterial = repaintedMaterial;
        if (isRepainted)
        {
            newMaterial = originalMaterial;
            isRepainted = false;
        } else
        {
            newMaterial = repaintedMaterial;
            isRepainted = true;
        }

        GetComponent<Renderer>().material = newMaterial;
    }
}
