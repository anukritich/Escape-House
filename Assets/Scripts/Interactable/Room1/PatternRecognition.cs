using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternRecognition : MonoBehaviour
{
    private List<Color> vibgyorPattern = new List<Color>();
    private List<Color> currentColors = new List<Color>();

    void Start()
    {
        // Define the VIBGYOR pattern
        vibgyorPattern.Add(new Color32(148, 0, 211, 255)); // Violet
        vibgyorPattern.Add(new Color32(75, 0, 130, 255));  // Indigo
        vibgyorPattern.Add(new Color32(0, 0, 255, 255));    // Blue
        vibgyorPattern.Add(new Color32(0, 255, 0, 255));    // Green
        vibgyorPattern.Add(new Color32(255, 255, 0, 255));  // Yellow
        vibgyorPattern.Add(new Color32(255, 165, 0, 255));  // Orange
        vibgyorPattern.Add(new Color32(255, 0, 0, 255));    // Red
    }

    public void AddColor(Color color)
    {
        currentColors.Add(color);
    }

    public bool CheckPattern()
    {
        if (currentColors.Count != vibgyorPattern.Count)
        {
            return false; // Pattern is not complete yet
        }

        for (int i = 0; i < vibgyorPattern.Count; i++)
        {
            if (vibgyorPattern[i] != currentColors[i])
            {
                return false; // Pattern does not match
            }
        }

        // Pattern matched
        currentColors.Clear(); // Clear the list after a successful pattern match
        return true;
    }
}
