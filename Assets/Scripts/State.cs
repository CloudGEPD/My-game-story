using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
   [TextArea(14,14)] public string coreStory;
   public State[] changeStates;

    public string CoreStory()
    {
        return coreStory;
    }

    public State[] ManageNextStates()
   {
       return changeStates;
   }

}
