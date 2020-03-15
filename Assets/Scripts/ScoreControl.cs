using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text score;
    void Start()
    {
        score.text = PlayerPrefs.GetInt("Score").ToString();
    }

}
