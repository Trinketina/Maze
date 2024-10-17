using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject pausePanel;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pausePanel.activeSelf)
            {
                Time.timeScale = 0f;
                pausePanel.SetActive(true);
                UnityEngine.Cursor.visible = true;

            }
            else
            {
                Resume();
            }
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        UnityEngine.Cursor.visible = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}
