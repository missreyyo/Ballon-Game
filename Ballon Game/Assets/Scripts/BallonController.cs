using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    public GameObject shot;
    GameController GameControllers;
    void Start(){
        GameControllers = GameObject.Find("Scripts").GetComponent<GameController>();
    }
    void OnMouseDown(){
        GameObject go=Instantiate(shot,transform.position,transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0333f);
        GameControllers.addBallon();

    }
 
}
