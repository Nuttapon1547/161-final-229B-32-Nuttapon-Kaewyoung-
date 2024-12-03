using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal 
{ 
    private float dailyfoodConsumption = 0.2f;
    private int weight = 3;

    private void Start()
    {
        animalName = "Bird";
        Init(animalName);
        MakeSound();
        CalculateFoodRequirment();
    }
    public override float CalculateFoodRequirment()
    {
        Debug.Log($"{animalName} eats food {dailyfoodConsumption} kg. everyday and weight {weight} kg");
        float weeklyFoodRequirment = dailyfoodConsumption * weight * 7;
        Debug.Log($"Every week {animalName} eats food {weeklyFoodRequirment} kg.");
        return weeklyFoodRequirment;
    }
    public override void MakeSound()
    {
        Debug.Log($"{animalName} makes sound");
        Debug.Log($"{animalName} chirps : Jib Jib");
    }
}
