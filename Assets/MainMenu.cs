using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        UnityEngine.Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Extras()
    {
        SceneManager.LoadScene("LevelConcept1");
    }
}
