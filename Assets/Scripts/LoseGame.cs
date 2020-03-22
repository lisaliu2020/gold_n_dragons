using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseGame : MonoBehaviour
{
    [SerializeField] Text myText;
    static State losingState;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = losingState.GetStateStory();
    }

    public static void GetState(State lose)
    {
        losingState = lose;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
