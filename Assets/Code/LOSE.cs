using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LOSE : MonoBehaviour

{
    public GameObject panel;
    public TextMeshProUGUI scoreText;
    public int Score;
    public void TurnOnUI()
    {
        panel.SetActive(true);
    }

    public void HideUI()
    {
        panel.SetActive(false);
    }

    public void Defeat()
    {
        scoreText.text = Score.ToString();
        TurnOnUI();
    }

    public void illmao()
    {
        print("touch");
        SceneManager.LoadScene(0);
    }
}
