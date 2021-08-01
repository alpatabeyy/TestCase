using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score { get; set; }
    [SerializeField]
    Text text;
    public void Manage()
    {
        text.text = "SCORE : " + score.ToString();
    }
}
