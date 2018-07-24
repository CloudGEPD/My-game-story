using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameStory : MonoBehaviour
{
    TextMeshProUGUI coreStory;
    State states;
    void ManageNextStates()
    {
        coreStory = states.();
        
    }
}
