using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyThrow : MonoBehaviour {

    public static int candyHeld;
    public Image loadingThrow;
    public GameObject dummyCandy;
    public GameObject candyPrefab;
    public Transform player;

    float timer;
    public float candyTimer = 2.0f;
    bool isLoading;

    void Update()
    {
        if (isLoading && candyHeld > 0)
        {
            timer += Time.deltaTime;
            loadingThrow.fillAmount = timer / candyTimer;

            if (loadingThrow.fillAmount == 1.0f)
            {
                ThrowCandy();
                isLoading = false;
                loadingThrow.fillAmount = 0;
            }
        }
    }

    public void OnCowLook()
    {
        isLoading = true;
    }

    public void ThrowCandy()
    {
        //Destroy(candyGO);
        candyHeld--;
        GameObject newCandy = Instantiate(candyPrefab, player.position, Quaternion.identity);
        newCandy.SetActive(true);
        newCandy.GetComponent<Rigidbody>().AddForce(player.forward * 600f);
        if (candyHeld <= 0)
        {
            dummyCandy.SetActive(false);
        }
    }

    public void ResetThrow()
    {
        isLoading = false;
        timer = 0.0f;
        loadingThrow.fillAmount = 0;
    }
}
