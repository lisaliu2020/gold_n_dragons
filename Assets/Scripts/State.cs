using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] private string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] int karmaPoints;
    [SerializeField] bool lost;
    

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }

    public int GetKarmaPoints()
    {
        return karmaPoints;
    }

    public bool GetDidLose()
    {
        return lost;
    }
}
