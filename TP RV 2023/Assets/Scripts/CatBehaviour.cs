using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    public GameObject worldObject;
    private AudioSource collisionSound;
    public GameObject fx;

    // Start is called before the first frame update
    void Start()
    {
        worldObject = GameObject.Find("World");
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        
        if(other.tag == "Player"){
            Destroy(gameObject);
            if(collisionSound){
                collisionSound.Play();
            }
            Instantiate(fx, transform.position, Quaternion.identity);
            worldObject.SendMessage("AddHit");
            GameVariables.catBotsTouches++;
            //Debug.Log(GameVariables.catBotsTouches);
        } 
    }
}
