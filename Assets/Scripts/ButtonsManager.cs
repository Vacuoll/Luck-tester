using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ButtonsManager : MonoBehaviour
{
    private int number;
    private int score = 0;
    public Text Score;
    public GameObject _interface;
    public GameObject _losePanel;
    private int scoreMax;

    private void Start()
    {
        number = Random.Range(0, 2);
    }

    public void TestButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void Button0()
    {
        if (number == 0)
            Next();
        else
            Lose();
    }

    public void Button1()
    {
        if (number == 1)
            Next();
        else
            Lose();
    }

    private void Randomazer()
    {
        number = Random.Range(0, 2);
    }

    private void Lose()
    {
        scoreMax = PlayerPrefs.GetInt("Score");
        if(score > scoreMax)
            PlayerPrefs.SetInt("Score", score);
        _interface.SetActive(false);
        _losePanel.SetActive(true);
    }

    private void Next()
    {
        score++;
        Score.text = score.ToString();
        Randomazer();
    }
}
