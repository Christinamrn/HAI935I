using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IcecreamBehaviour : MonoBehaviour
{
    TMP_Text icecreamtxt;
    // Start is called before the first frame update
    void Start()
    {
        icecreamtxt = GameObject.Find("icecreamtext").GetComponent<TMPro.TMP_Text>();
        icecreamtxt.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Debug.Log("Collider glace");
            Destroy(gameObject);
            icecreamtxt.gameObject.SetActive(true);
        }

    }
}
