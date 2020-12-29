using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour
{
    //controls the scene 
    public KeyCode pause;
    public KeyCode resume;
    public KeyCode reload;
    public KeyCode SpeedUp;
    public KeyCode speedset1;
    public KeyCode speedset2;



    private void Start()
    {
        //Time.timeScale = 0f;

    }
    private void Update()
    {
        if (Input.GetKeyDown(pause))
            PauseGame();
        if (Input.GetKeyDown(resume))
            ResumeGame();
        if (Input.GetKeyDown(reload))
            ReloadGame();
        if (Input.GetKeyDown(SpeedUp))
            SpeedUpGame();
        if (Input.GetKeyDown(speedset1))
            speed1();
        if (Input.GetKeyDown(speedset2))
            speed2();
        

    }
    void PauseGame()

    {
        Time.timeScale = 0;
    }
    void speed1()

    {
        Time.timeScale = 1;
    }
    void speed2()

    {
        Time.timeScale = 1.5f;
    }

    void ResumeGame()
    {
        Time.timeScale = 2f;
    }
    void ReloadGame()
    {
        SceneManager.LoadScene("Physics Track");
    }
    void SpeedUpGame()
    {
        Time.timeScale = 0.5f;

    }
}