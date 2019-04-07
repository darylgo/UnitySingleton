using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondSceneManager : MonoBehaviour
{
    public Text valueText;

    private void Start()
    {
        valueText.text = GameManager.Instance.Value.ToString();
    }

    public void OnButtonClick()
    {
        GameManager.Instance.Value++;
        SceneManager.LoadScene("FirstScene");
    }
}
