using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public static int points;
    public static Points instance;
    [SerializeField]private TMP_Text scoreText;
    private int savedHighScore;
    private void Start()
    {
        instance = this;
        int savedPoints = PlayerPrefs.GetInt("Points:", points);
        scoreText.text = $"Points: {savedPoints}";
    }

    // Start is called before the first frame update
    public void AddPoints()
    {

        points++;
        int savedPoints = PlayerPrefs.GetInt("Points:", points);
        scoreText.text = $"Points: {savedPoints}";
   }
}
