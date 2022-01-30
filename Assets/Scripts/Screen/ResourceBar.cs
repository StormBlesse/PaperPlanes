using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBar : MonoBehaviour 
{
    private const int maxResources;
    private static int currentResources;
    private const int regenerationSpeed;
    private const double windScale;

    void Start()
    {
        maxResources = 100;
        currentResources = 100;
        regenerationSpeed = 1;
        windScale = 0.5;
    }

    void Update()
    {
        // regenerate resource bar every 1 sec
        currentResources += regenerationSpeed;
        currentResources = Math.Min(currentResources, maxResources);

        // update visuals of resource bar
    }

    void collision(int reduction)
    {
        // reduce resource bar when collision happens
        currentResources -= reduction;
        currentResources = Math.Max(currentResources, 0);

        // update visuals of resource bar
    }

    void addResource(int addition)
    {
        // increase resource bar when items are used
        currentResources += addition;
        currentResources = Math.Min(currentResources, maxResources);
        
        // update visuals of resource bar
    }

    void windResourceUsage(double windLength)
    {
        // reduce resource bar when collision happens
        currentResources -= (int)(windLength * windScale);
        currentResources = Math.Max(currentResources, 0);

        // update visuals of resource bar
    }
}