using UnityEngine;

public class ColorCheckVoilet: MonoBehaviour
{
    public Color targetColor = new Color(0.58f, 0f, 0.83f, 1f); // Set your desired color in the Inspector
    private Renderer render;
    public bool check = false;

    void Start()
    {
        render = GetComponent<Renderer>();
        
    }

    void Update()
    {
        // Check if the color of the material matches the target color
        if (IsColorMatching(render.material.color, targetColor))
        {
            check = true;
            Debug.Log("Voilet colour matched");
           
        }
    }
    bool IsColorMatching(Color current, Color target, float tolerance = 0.05f)
    {
        return Mathf.Abs(current.r - target.r) < tolerance &&
               Mathf.Abs(current.g - target.g) < tolerance &&
               Mathf.Abs(current.b - target.b) < tolerance &&
               Mathf.Abs(current.a - target.a) < tolerance;
    }
}
