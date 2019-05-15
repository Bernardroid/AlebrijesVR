using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCollision : MonoBehaviour {

    public GameObject starsPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Alebrije"))
        {
            Instantiate(starsPrefab, collision.transform);
            Destroy(this.gameObject);
        }
    }
}
