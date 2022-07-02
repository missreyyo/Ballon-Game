using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonCreator : MonoBehaviour
{
    GameController GameControllers;
    public GameObject ballon;
    float ballonCreatorTime = 1f;
    float timeCounter=0f;
    // Start is called before the first frame update
    void Start()
    {
        GameControllers = this.gameObject.GetComponent<GameController> ();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter -=Time.deltaTime;
        int multiple= (int)(GameControllers.timeCounter/10)-6;
        multiple *=-1;
        if(timeCounter<0 && GameControllers.timeCounter>0){
            GameObject go=Instantiate(ballon, new Vector3 (Random.Range(0f,4f),89f,0), Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0,Random.Range(35f*multiple,80f*multiple),0));
            timeCounter= ballonCreatorTime;
        }
    }
}
