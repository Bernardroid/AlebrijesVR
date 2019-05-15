    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyBehaviour : MonoBehaviour {

    public Image loadingCandy;
    public GameObject dummyCandy;
    public GameObject candyUI;

    float timer;
    public float candyTimer = 2.0f;
    bool isLoading;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        if (isLoading)
        {
            timer += Time.deltaTime;
            loadingCandy.fillAmount = timer / candyTimer;

            if(loadingCandy.fillAmount == 1.0f)
            {
                isLoading = false;
                GrabCandy();
            }
        }
    }

    public void OnCandyLook()
    {
        isLoading = true;
    }

    public void GrabCandy()
    {
        dummyCandy.SetActive(true);
        CandyThrow.candyHeld++;
        //candyUI.SetActive(true);
        Destroy(this.gameObject);
    }

    public void ResetCandy()
    {
        isLoading = false;
        timer = 0.0f;
        loadingCandy.fillAmount = 0;
    }
}
