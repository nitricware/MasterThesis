using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WasGuckstDu : MonoBehaviour
{
    public Text hintBox;
    private Dictionary<string, string> labels;

	// Use this for initialization
	void Start ()
	{
        labels = new Dictionary<string, string>
        {
            {"metacarpals", "Mittelhandknochen" },
            {"carpals", "Handwurzelknochen" },
            {"arm", "Radius/Ulna" },
            {"interossi", "m. interossi" },
            {"flexorPollicisTendon", "Daumenflexorsehne" },
            {"flexorTendons", "Fingerflexorensehnen" },
            {"discus", "discus interarticularis" },
            {"aulnaris", "a. ulnaris" }
        };
	}
	
	// Update is called once per frame
	void Update ()
	{
        RaycastHit hitInfo;
        if (Physics.Raycast(
                Camera.main.transform.position,
                Camera.main.transform.forward,
                out hitInfo,
                20.0f,
                Physics.DefaultRaycastLayers))
        {
            if (labels.ContainsKey(hitInfo.collider.name))
            {
                hintBox.text = labels[hitInfo.collider.name];
            } else
            {
                hintBox.text = "";
            }
        } else
        {
            hintBox.text = "";
        }
    }
}