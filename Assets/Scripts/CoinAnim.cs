using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnim : MonoBehaviour
{
    //[SerializeField]
    private GameObject coin;
    //[SerializeField]
    private Animator coinAnim;
    private String animName;
    private String toControl;

    void ListAnimParams()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        /*if (coin == null || coinAnim == null) {
            coin = GameObject.Find("wallet");
            coinAnim = coin.GetComponent<Animator>();
        }*/

        coin = GameObject.Find("Coin");
        coinAnim = coin.GetComponent<Animator>();
        Debug.Log(coinAnim);
        animName = "Armature|Open";
        toControl = "IsFly";
        coin.active = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("FLY NOWE");
            coin.active = true;
            coinAnim.SetBool(toControl, true);//.Play(animName);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            coin.active = false;
            coinAnim.SetBool(toControl, false);

        }

    }
}
