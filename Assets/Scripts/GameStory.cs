using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStory : MonoBehaviour
{
    State states;
    
    void ManageNextStates()
    {
        states.DiffStates();

    }
}
