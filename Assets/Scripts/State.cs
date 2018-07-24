using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class State : ScriptableObject
{
    public State states;
    
    [SerializeField] TextMeshProUGUI textmesh;
    [TextArea(10,14)] [SerializeField]  string storyText;
    [SerializeField] State[] state;
    

    public string StoryText()
    {
        return storyText;
    }

    public State[] DiffStates()
    {
        return state;
    }

}
