using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBaseControl : MonoBehaviour
{
    CharacterMovementModel characterMovementModel;
    CharacterInteractionModel characterInteractionModel;

    int quantesVegadesEspai;

    void Awake()
    {
        characterMovementModel = GetComponent<CharacterMovementModel>();
        characterInteractionModel = GetComponent<CharacterInteractionModel>();
        quantesVegadesEspai = 0;
    }

    protected void SetDirection(Vector2 direction)
    {
        if (null == characterMovementModel)
        {
            return;
        }
        characterMovementModel.SetDirection(direction);
    }

    protected void OnActionPressed()
    {
        /*
        aquí incrementem el numero de vegades que s'ha apretat espai
         
        quantesVegadesEspai = quantesVegadesEspai + 1;
        Debug.Log("quantes vegades s'ha apretat l'espai: "+quantesVegadesEspai);
        */
        if (null == characterInteractionModel)
        {
            return;
        }
        characterInteractionModel.OnInteract();
    }
}
