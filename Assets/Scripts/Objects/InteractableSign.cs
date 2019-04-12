using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSign : InteractableBase 
{
    public override void OnInteract()
    {
        Debug.Log("Interact with sign");
    }
}