using UnityEngine;

public class LampGlow : MonoBehaviour
{
    public Light lampLight;
    public float glowSpeed = 1.0f;
    public float minIntensity = 0.0f;
    public float maxIntensity = 2.0f;

    private void Update()
    {
        // Calculate the intensity based on time
        float intensity = Mathf.Lerp(maxIntensity, minIntensity, Time.time * glowSpeed);
        lampLight.intensity = intensity;
    }
}
