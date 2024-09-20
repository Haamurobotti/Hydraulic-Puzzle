using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject levelSelectButton;
    public GameObject mainMenu;
    public GameObject levelSelect;
    [SerializeField] private TMP_Text leve2LockText;
    [SerializeField] private TMP_Text leve3LockText;

    int points;
    // Start is called before the first frame update
    void Start()
    {
        // levelSelectButton = GetComponent<GameObject>();
        //mainMenu = GetComponent<GameObject>();
        //levelSelect = GetComponent<GameObject>();
       
    }

    // Update is called once per frame
    void Update()
    {
        points = Points.points;
        leve2LockText.text = "Locked need 5 points";
        leve3LockText.text = "Locked need 15 points";
        if (points >= 5)
        {
            leve2LockText.text = "Unlocked";
        }
        if (points >= 15)
        {
           
            leve3LockText.text = "Unlocked";
        }

    }
    public void LevelSelectButton()
    {
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }
    public void MainMenuButton()
    {
        mainMenu.SetActive(true);
        levelSelect.SetActive(false);
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadSecretLevel()
    {
        SceneManager.LoadScene("SecretLevel");
    }
    public void LoadLevel2()
    {
        
        if (points >= 5)
        {
            SceneManager.LoadScene("Level 2");
        }
        else
        {
            Debug.Log("Ei tarpeeksi pisteit");
        }
    }
    public void LoadLevel3()
    {
        if (points >= 15)
        {
            SceneManager.LoadScene("Level 3");
        }
        else
        {
            Debug.Log("Ei tarpeeksi pisteit");
        }
    }

}
