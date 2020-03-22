using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlayDragons : MonoBehaviour
{
    [SerializeField] Text myText;
    [SerializeField] State startingState;
    [SerializeField] State need_sword_armour;
    bool hasSword = false;
    bool hasArmour = false;
    int karmaPoints = 0;
    bool canKillDragon = true;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        myText.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();

    }

    private void ManageStates()
    {
        //can use var if it's initialized
        State[] nextStates = state.GetNextStates();

        for(int i = 0; i < nextStates.Length; i++)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene("Start");
            }

            if (state.name.Equals("leave_room") && (!hasSword || !hasArmour))
            {
                state = need_sword_armour;
            }
        }

        //to set the boolean's to true or false - must have sword & armour
        if (state.name.Equals("store_sword"))
        {
            hasSword = true;
        }
        else if(state.name.Equals("wear_armour"))
        {
            hasArmour = true;
        }

        karmaPoints += state.GetKarmaPoints();

        //if your karma points go over 20 dragon will kill u :) ...
        if(karmaPoints >= 20)
        {
            canKillDragon = false;
        }
        else
        {
            canKillDragon = true;
        }

        if (state.GetDidLose() || (!canKillDragon && state.name.Contains("ending")))
        {
            LoseGame.GetState(state);
            SceneManager.LoadScene("Lost");
        }
        else if(canKillDragon && state.name.Contains("ending"))
        {
            WinGame.GetState(state);
            SceneManager.LoadScene("Won");
        }
        else
        {
            myText.text = state.GetStateStory();
        }
    }
}
