using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ResourceBar : MonoBehaviour 
{
    private static int maxResources;
    private static int currentResources;
    private static int regenerationSpeed;
    private static double windScale;

    void Start()
    {
        maxResources = 100;
        currentResources = maxResources;
        regenerationSpeed = 1;
        windScale = 0.5;

        // run void regeneration() every 1s after 1s delay
        InvokeRepeating("regeneration", 1f, 1f);
    }

    // checks that currentResources are within limits and updates UI
    void updateUI()
    {
        // checks that 0 < currentResources < maxResources
        currentResources = Math.Max(currentResources, 0);
        currentResources = Math.Min(currentResources, maxResources);

        // update UI
    }

    // regenerate resource bar by regenerationSpeed every 1 sec
    void regeneration()
    {
        currentResources += regenerationSpeed;
        updateUI();
    }

    // reduce resource bar when collision happens
    void collision(int reduction)
    {
        currentResources -= reduction;
        updateUI();
    }

    // increase resource bar when items are used
    void addResource(int addition)
    {
        currentResources += addition;
        updateUI();
    }

    // reduce resource bar when collision happens
    void windResourceUsage(double windLength)
    {
        currentResources -= (int)(windLength * windScale);
        updateUI();
    }

    // sets resource bar capacity
    void setCapacity(int capacity)
    {
        maxResources = capacity;
    }

    // increase resource bar capacity
    void increaseCapacity(int increase)
    {
        maxResources += increase;
    }
    
    // decrease resource bar capacity
    void decreaseCapacity(int decrease)
    {
        maxResources -= decrease;
    }

    // set resource bar regeneration speed
    void setRegenerationSpeed(int regeneration)
    {
        regenerationSpeed = regeneration;
    }

    // increase resource bar regeneration speed
    void increaseRegenerationSpeed(int increase)
    {
        regenerationSpeed += increase;
    }

    // decrease resource bar regeneration speed
    void decreaseRegenerationSpeed(int decrease)
    {
        regenerationSpeed -= decrease;
    }
}