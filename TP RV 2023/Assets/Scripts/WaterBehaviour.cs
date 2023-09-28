using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WaterBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        Debug.Log("Collision");
        Debug.Log(GameVariables.catBotsTouches +"sur"+ GameVariables.nbCatBots);
        if(other.tag == "Player" && GameVariables.catBotsTouches == GameVariables.nbCatBots){
            SceneManager.LoadScene("carouselScene");
        }
    }
}
