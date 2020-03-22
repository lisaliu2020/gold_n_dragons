using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{
    [SerializeField] Text myText;
    static State winState;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = winState.GetStateStory();
    }

    public static void GetState(State win)
    {
        winState = win;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
