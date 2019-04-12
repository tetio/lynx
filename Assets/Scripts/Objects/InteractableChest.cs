using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableChest : InteractableBase 
{
    public override void OnInteract()
    {
        Debug.Log("Interact with chest");
    }
}