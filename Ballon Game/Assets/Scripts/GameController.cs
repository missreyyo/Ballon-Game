using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
  
    public UnityEngine.UI.Text timeText, ballonText;
    public float timeCounter = 60;
    int shottingCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(timeCounter>0){
       timeCounter -= Time.deltaTime;
       timeText.text="Time: "+ (int)timeCounter; 
       }
       else{
        GameObject[] gameobj = GameObject.FindGameObjectsWithTag ("ballon");
        for(int i=0;i<gameobj.Length;i++){
            Destroy(gameobj [i]);
        }
        

       }
    }
    public void addBallon(){
        shottingCounter +=1;
        ballonText.text="Score: "+shottingCounter;
    }
}
