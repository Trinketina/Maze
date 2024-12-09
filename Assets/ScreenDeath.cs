using UnityEngine;
using UnityEngine.SceneManagement;
public class ScreenDeath : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(-(Camera.main.orthographicSize + 1));
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Death by falling off Screen
        if (player.transform.position.y < - (Camera.main.orthographicSize + 1) )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
