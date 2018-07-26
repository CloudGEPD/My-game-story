using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoreGameplay : MonoBehaviour
{
     State state;
    [SerializeField] TextMeshProUGUI textmesh;
    [SerializeField] State startingState;
    
    private void Start()
    {
        state = startingState;
        textmesh.text = state.CoreStory();
    }

    private void Update()
    {
        GetNextStates();
    }

    void GetNextStates()
    {
        var nextStates = state.ManageNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            state = nextStates[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[1];
        }
        textmesh.text = state.CoreStory();
      
    }
	
}
