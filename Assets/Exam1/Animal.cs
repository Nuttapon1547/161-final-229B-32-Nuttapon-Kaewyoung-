using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string _name)
    {
        animalName = _name;
        Debug.Log(animalName);
    }

    public abstract float CalculateFoodRequirment();
    public virtual void MakeSound() { }
    public void DisplayName() { }
}
