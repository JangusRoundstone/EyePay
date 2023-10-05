using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimateOnPress : MonoBehaviour
{
    //[SerializeField]
    private GameObject coin;
    //[SerializeField]
    private Animator coinAnim;
    private String animName;
    private String toControl;

    void ListAnimParams() { 
        
    }

    // Start is called before the first frame update
    void Start()
    {
        /*if (coin == null || coinAnim == null) {
            coin = GameObject.Find("wallet");
            coinAnim = coin.GetComponent<Animator>();
        }*/

        coin = this.gameObject;
        coinAnim = GetComponent<Animator>();
        Debug.Log(coinAnim);
        animName = "Armature|Open";
        toControl = "IsOpening";
        VInput.onVInputEvent += _onVInputEvent;

    }

    // Update is called once per frame
    void Update()
    {
        VInput.Update(Time.unscaledDeltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Space key was released.");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("OPEN NOW PLEASE");
            coinAnim.SetBool(toControl, true);//.Play(animName);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            //coinAnim.Play(animName, -1, 0f);
            coinAnim.SetBool(toControl, false);
            
        }

    }

    protected virtual void _onVInputEvent(VINPUT_EVENT pEvent)
    {
        switch (pEvent)
        {
            case VINPUT_EVENT.TAP_1FINGER:
                Debug.Log("OPEN NOW PLEASE");
                coinAnim.SetBool(toControl, true);//.Play(animName);
                break;
            case VINPUT_EVENT.TAP_2FINGER:
                coinAnim.SetBool(toControl, false);
                break;
            case VINPUT_EVENT.SWIPE_FORWARD_1FINGER:
                break;
            case VINPUT_EVENT.SWIPE_BACKWARD_1FINGER:
                break;
        }
    }
}
