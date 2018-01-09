using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class DeactivateArteria : MonoBehaviour, IInputClickHandler
{

    private GameObject[] arterias;
    private bool areActive;

	// Use this for initialization
	void Start ()
	{
        areActive = true;
        arterias = GameObject.FindGameObjectsWithTag("arteria");
    }
	
	// Update is called once per frame
	void Update ()
	{
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        foreach (GameObject arteria in arterias)
        {
            if (areActive)
            {
                arteria.SetActive(false);
            } else
            {
                arteria.SetActive(true);
            }
        }

        if (areActive)
        {
            areActive = false;
        }
        else
        {
            areActive = true;
        }
    }
}