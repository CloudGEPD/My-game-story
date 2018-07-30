using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
   [TextArea(14,14)] [SerializeField] string coreStory;
   [SerializeField] State[] changeStates;

    public string CoreStory()
    {
       return coreStory;
   }

    public State[] ManageNextStates()
   {
       return changeStates;
   }

}
