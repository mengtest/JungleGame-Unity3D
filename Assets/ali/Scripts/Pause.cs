using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public GameObject StartCanvas;
    public GameObject pauseButton, pausePanel;
    public GameObject JoystickCanvas;
    public GameObject MuteBTN;

    bool isMute;

    public void Start () {
        OnUnPause();
    }
    public void Mute()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
       
    }
    // Update is called once per frame
    public void OnPause () {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        JoystickCanvas.SetActive(false);

        Time.timeScale = 0;
    }

    public void OnUnPause()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        JoystickCanvas.SetActive(true);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        StartCanvas.SetActive(true);
        pausePanel.SetActive(false);
    }

}
