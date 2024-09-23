using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    public int gameManagerCount;

    public float health;
    public float experience;
    public int level;
    public int gold;
    public int score;
    public int lives;

    // Start is called before the first frame update
    void Awake()
    {
        if (manager == null)
        {
            DontDestroyOnLoad(gameObject);
            manager = this;
        }
        else if (manager != this)
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene(0); // press 1
        if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene(1); // press 2
        if (Input.GetKeyDown(KeyCode.Alpha3)) SceneManager.LoadScene(2); // press 3
        if (Input.GetKeyDown(KeyCode.Alpha4)) SceneManager.LoadScene(3); // press 4

        GameObject[] instances = GameObject.FindGameObjectsWithTag("GameManager");
        gameManagerCount = instances.Length;
    }

    public void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
        GUI.Label(new Rect(10, 40, 150, 30), "Experience: " + experience);
        GUI.Label(new Rect(10, 70, 100, 30), "Level: " + level);
        GUI.Label(new Rect(10, 100, 100, 30), "Gold: " + gold);
        GUI.Label(new Rect(10, 130, 100, 30), "Score: " + score);
        GUI.Label(new Rect(10, 160, 100, 30), "Lives: " + lives);
        GUI.Label(new Rect(10, 190, 150, 30), "Game Manager Count: " + gameManagerCount);
    }
}
