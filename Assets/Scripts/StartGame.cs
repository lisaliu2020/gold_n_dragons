using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] Button playBtn;
    [SerializeField] Button howToPlayBtn;

    // Start is called before the first frame update
    void Start()
    {
        playBtn.onClick.AddListener(WhenClicked);
        howToPlayBtn.onClick.AddListener(HowToPlay);
    }

    private void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    private void WhenClicked()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
