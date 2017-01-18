using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartCanv : MonoBehaviour {

    public GameObject CanvasPause;
    public GameObject PauseBTN;
    public GameObject StartCanvas;
    public GameObject JoystickCanvas;
    public GameObject JoystickCanvas2;

    public void Update()
  {
        CanvasPause.SetActive(false);
        AudioListener.volume = 0;


    }

    public void StartButton()
    {
      
        StartCanvas.SetActive(false);
        CanvasPause.SetActive(true);
        JoystickCanvas.SetActive(true);
        JoystickCanvas2.SetActive(true);
        PauseBTN.SetActive(true);
        Time.timeScale = 1;
        AudioListener.volume = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
