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
    public void LoadLevel2()
    {
        
        if (points >= 0)
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
        if (points >= 100)
        {
            SceneManager.LoadScene("Level 3");
        }
        else
        {
            Debug.Log("Ei tarpeeksi pisteit");
        }
    }

}
