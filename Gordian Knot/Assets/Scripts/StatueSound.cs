using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueSound : MonoBehaviour
{
    
    public AudioClip statueSound;

    private AudioManager theAM;
    // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollionEnter2D(Collision2D col)
    {
        theAM.ChangeBGM(statueSound);
    }
}
