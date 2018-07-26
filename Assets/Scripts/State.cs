using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{ 
[TextArea(10, 14)] public string coreStory;
 [SerializeField] State[] nextStates;
    
   
    public string CoreStory()
    {
       
        return coreStory;
    }

    public State[] ManageNextStates()
    {
        return nextStates;
    }
 
    

}
