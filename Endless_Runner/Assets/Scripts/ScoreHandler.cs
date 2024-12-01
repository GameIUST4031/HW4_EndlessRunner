using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    PlayerMovement Player;
    private Text[] texts;
    void Start()
    {
        Player=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        texts = GetComponentsInChildren<Text>();
        texts[0].text = $"HighestScore:\t{Player.highScore}";
        texts[1].text = $"Score:    {Player.currentScore}";
    }

    // Update is called once per frame
    void Update()
    {
        texts[0].text = $"HighestScore:\t{Player.highScore}";
        texts[1].text = $"Score:    {Player.currentScore}";
    }
}
