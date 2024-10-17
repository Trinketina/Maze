using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtrasPanel : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject panel;
    public string nextL;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
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
    public void Okay()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }
    
    public void NextTest()
    {
        SceneManager.LoadScene(nextL);
    }
}
