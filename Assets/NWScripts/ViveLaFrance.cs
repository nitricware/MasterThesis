using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveLaFrance : MonoBehaviour
{
    public GameObject fireworks;

    private Material metacarpalsMat;
    private Material carpalsMat;
    private Material armMat;

    // Use this for initialization
    void Start ()
	{
        
    }
	
	// Update is called once per frame
	void Update ()
	{
        metacarpalsMat = GameObject.Find("Metacarpals").GetComponent<Renderer>().material;
        carpalsMat = GameObject.Find("Carpals").GetComponent<Renderer>().material;
        armMat = GameObject.Find("Arm").GetComponent<Renderer>().material;

        if (metacarpalsMat.name == "blueMaterial (Instance)" &&
            carpalsMat.name == "boneMaterial (Instance)" &&
            armMat.name == "redMaterial (Instance)")
        {
            fireworks.SetActive(true);
        } else
        {
            fireworks.SetActive(false);
        }

        
    }
}