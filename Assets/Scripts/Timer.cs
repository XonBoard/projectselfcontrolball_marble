using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerLabel;
    public GameObject Restart;
    private float time;
    public GameObject End,pointend;
    public RectTransform score;
    public Image cv;
    private int i, y = 90;

    private void Start()
    {
        //time = -3f;
    }
    void Update()
    {
        time += Time.unscaledDeltaTime;

        //var minutes = time / 60; //Divide the guiTime by sixty to get the minutes.
        //var seconds = time % 60;//Use the euclidean division for the seconds.
        var fraction = (time * 100) % 100;
        int minutes = Mathf.FloorToInt(time / 60F);
        int seconds = Mathf.FloorToInt(time - minutes * 60);
        string niceTime = string.Format("{0:0}:{1:00} : {2:00}", minutes, seconds, fraction);

        //update the label value
        //timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
        timerLabel.text = niceTime;
        if (seconds >= 30)
        {
            minutes -= 1;
            Debug.LogWarning("minutes");
        }
        if (seconds == 59)
        {
            minutes += 1;
        }
        if(GameObject.Find("pointLap").GetComponent<StartGameCounter>().lapit == true)
        {
            Debug.Log("stop the game");
            End.SetActive(true);
            pointend.SetActive(true);

            //Time.timeScale = 0;

            if (pointend.GetComponent<EndgameCounter>().endit == true)
            {
                score.anchoredPosition = new Vector3(0, 0, 0);
                score.localScale = new Vector3(4, 4, 4);
                var tempColor = cv.color;
                tempColor.a = 0;
                cv.color = tempColor;
                Restart.SetActive(true);
                GameObject.Find("SceneManager").GetComponent<Timer>().enabled = false;
            }

        }
    }
}