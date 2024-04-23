using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Interactable
{
    private PatternRecognition patternRecognition;
    public Color cubeColor;
    // Start is called before the first frame update
    void Start()
    {
        patternRecognition = FindObjectOfType<PatternRecognition>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this function is where we will design our interaction using code 
    protected override void Interact()
    {
        Debug.Log("Interact with " + gameObject.name);

    }
    public void OnMouseDown()
    {
        if (patternRecognition != null)
        {
            patternRecognition.AddColor(cubeColor);
            if (patternRecognition.CheckPattern()) // Check if the pattern is matched
            {
                // Trigger the animation here
                Debug.Log("VIBGYOR pattern matched, triggering animation");
            }
        }
    }
}
