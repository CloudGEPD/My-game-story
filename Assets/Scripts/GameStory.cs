using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStory : MonoBehaviour
{
    [SerializeField] State firstState;
    [SerializeField] TextMeshProUGUI coreStory;
    State state;

    private void Start()
    {
        GetNextStates();
    }

    private void Update()
    {
        ManageNextStates();
    }


    void ManageNextStates()
    {
        var nextStates = state.DiffStates();
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            state = nextStates[0];
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[1];
        }
        coreStory.text = state.StoryText();
        
    }

    void GetNextStates()
    {
        state = firstState;
        coreStory.text = state.StoryText();
    }
}
