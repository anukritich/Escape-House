using UnityEngine;

public class Indigo : MonoBehaviour
{
    public Color targetColor = new Color(0.294f, 0f, 0.51f, 1f); // Indigo
    private Renderer render;
    public static bool check = false;
  

    void Start()
    {
        render= GetComponent<Renderer>();
        
    }

    void Update()
    {
        // Compare the current color to the target color with a small tolerance to account for minor differences
        if (IsColorMatching(render.material.color, targetColor))
        {
            check = true;
            Debug.Log("Indigo colour matched");
        }
    }

    // Method to compare two colors with a tolerance
    bool IsColorMatching(Color current, Color target, float tolerance = 0.05f)
    {
        return Mathf.Abs(current.r - target.r) < tolerance &&
               Mathf.Abs(current.g - target.g) < tolerance &&
               Mathf.Abs(current.b - target.b) < tolerance &&
               Mathf.Abs(current.a - target.a) < tolerance;
    }
}
