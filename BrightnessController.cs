using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessController : MonoBehaviour
{
    public Transform character;
    public Transform shinyObject;
    public Light environmentLight;
    public float maxBrightness = 1f;
    public float minBrightness = 0.5f;
    public float maxDistance = 10f;

    private float initialBrightness;

    private void Start()
    {
        // Store the initial brightness of the environment light
        initialBrightness = environmentLight.intensity;
    }

    private void Update()
    {
        // Calculate the distance between the character and shiny object
        float distance = Vector3.Distance(character.position, shinyObject.position);

        // Calculate the brightness based on the distance
        float brightness = Mathf.Lerp(minBrightness, maxBrightness, 1 - (distance / maxDistance));

        // Set the brightness of the environment light
        environmentLight.intensity = brightness;
    }
}
