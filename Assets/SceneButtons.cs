using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneButtons : MonoBehaviour {

    public Image loadingReset;

    float timer;
    public float resetTimer = 2.0f;
    bool isLoading;

    void Start()
    {

    }

    void Update()
    {
        if (isLoading)
        {
            timer += Time.deltaTime;
            loadingReset.fillAmount = timer / resetTimer;

            if (loadingReset.fillAmount == 1.0f)
            {
                isLoading = false;
                ResetScene();
            }
        }
    }

    public void OnButtonLook()
    {
        isLoading = true;
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ResetButton()
    {
        isLoading = false;
        timer = 0.0f;
        loadingReset.fillAmount = 0;
    }
}
