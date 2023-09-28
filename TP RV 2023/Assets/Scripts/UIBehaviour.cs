using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    TMP_Text timerText;
    TMP_Text sceneText;
    int nbCats = 0;
    //int currentTime = 60;
  

    // Start is called before the first frame update
    void Start()
    {   //Debug.Log(GameVariables.currentTime);
        StartCoroutine(TimerTick());
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        sceneText = GameObject.Find("finScene").GetComponent<TMPro.TMP_Text>();
        sceneText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void AddHit(){
        nbCats++;
        headText.text = "CatBots touchés : " + nbCats;
        if(nbCats == GameVariables.nbCatBots){
            sceneText.gameObject.SetActive(true);
        }
    }

    IEnumerator TimerTick(){
        //while(currentTime > 0){
        while(GameVariables.currentTime > 0){
            yield return new WaitForSeconds(1);
            GameVariables.currentTime--;
            timerText.text = "Time : " + GameVariables.currentTime.ToString();
        }
        SceneManager.LoadScene("catBotsScene");
    }
}
