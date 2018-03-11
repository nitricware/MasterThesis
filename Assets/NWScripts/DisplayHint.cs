using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHint : MonoBehaviour
{
    public Text hintBox;
    private Dictionary<string, string> labels;

	// Use this for initialization
	void Start ()
	{
        labels = new Dictionary<string, string>
        {
            {"metacarpals", "ossa metacarpi" },
            {"carpals", "ossa carpi" },
            {"arm", "radius/ulna" },
            {"interossi", "m. interossi" },
            {"flexorPollicisTendon", "tendo musculus flexor pollicis" },
            {"flexorTendons", "Tendo musculus flexor digitorum" },
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