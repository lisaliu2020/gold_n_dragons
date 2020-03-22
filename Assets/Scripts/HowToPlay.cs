using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToPlay : MonoBehaviour
{
    [SerializeField] Button backBtn;
    // Start is called before the first frame update
    void Start()
    {
        backBtn.onClick.AddListener(GoBack);
    }

    private void GoBack()
    {
        SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
