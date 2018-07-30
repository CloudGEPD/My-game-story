using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStory : MonoBehaviour
{
   [SerializeField] State startingState;
   [SerializeField] TextMeshProUGUI textmesh;

    State state;
	

	    void Start ()
    {
        state = startingState;
        textmesh.text = state.CoreStory();

        
	}
	
	

    void Update () 
   {
        GetNextStates();
	}

   void GetNextStates()
   {
        var changeStates = state.ManageNextStates();

        for (int index = 0; index < changeStates.Length ; index++)


        if(Input.GetKeyDown(KeyCode.Alpha1))
       {
           state = changeStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = changeStates[1];
        }

        textmesh.text = state.CoreStory();
    }
}
