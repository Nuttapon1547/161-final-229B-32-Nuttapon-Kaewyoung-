using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyfoodConsumption = 0.5f;
    private int activityLevel = 2;
    
    private void Start()
    {
        animalName = "Dog";
        Init(animalName);
        MakeSound();
        CalculateFoodRequirment();
    }
    public override float CalculateFoodRequirment()
    {
        Debug.Log($"Dog eats food {dailyfoodConsumption} kg. everyday and activity level {activityLevel}");
        float weeklyFoodRequirment = dailyfoodConsumption * activityLevel * 7;
        Debug.Log($"Every week dog eats food {weeklyFoodRequirment} kg.");
        return weeklyFoodRequirment;
    }
    public override void MakeSound()
    {
        Debug.Log($"{animalName} makes sound");
        Debug.Log($"{animalName} barks : Hong Hong!");
    }

}
