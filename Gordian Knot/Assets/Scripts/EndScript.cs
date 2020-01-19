using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour
{
    public Text endText;

    private float count;
    private float count2;


    // Start is called before the first frame update
    void Start()
    {
        endText.text = "";
      

    }

    // Update is called once per frame
    void Update()
    {
        count = count + Time.deltaTime;
        count2 = count2 + Time.deltaTime;
        if (count >= 12)
        {
            endText.text = "You Lose!";
            if (count2 >= 14)
            {
                Application.Quit();
            }
        
        }
    }
 
}
