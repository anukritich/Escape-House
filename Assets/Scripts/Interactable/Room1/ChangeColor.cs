using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer Renderer;
    public GameObject cube;
    private int colorIndex = 0;
    private Color32[] colors = new Color32[]
    {
        new Color32(148, 0, 211, 255),  // Violet
        new Color32(75, 0, 130, 255),   // Indigo
        new Color32(0, 0, 255, 255),    // Blue
        new Color32(0, 255, 0, 255),    // Green
        new Color32(255, 255, 0, 255),  // Yellow
        new Color32(255, 165, 0, 255),  // Orange
        new Color32(255, 0, 0, 255)     // Red
    };

    public virtual void ColorInteract()
    {
        ChangeColorVIBGYOR();
        Debug.Log("color");
    }

    protected void ChangeColorVIBGYOR()
    {
        if (Renderer != null)
        {
            Renderer.material.color = colors[colorIndex];
            Renderer.material.SetColor("_EmissionColor", colors[colorIndex]);
            colorIndex = (colorIndex + 1) % colors.Length; // Increment color index and loop back to 0 if it exceeds array length
        }
    }

}
