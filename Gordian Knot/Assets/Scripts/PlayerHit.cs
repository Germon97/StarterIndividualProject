using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public Text endText;

    public AudioClip newTrack;
    public AudioClip knotSound;
   
  
    private AudioManager theAM;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        endText.text = "";
        theAM = FindObjectOfType<AudioManager>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "Knot", if it is...
        if (other.gameObject.CompareTag("Knot"))
        {
            other.gameObject.SetActive(false);
            endText.text = "You Win!";
            if (newTrack != null)
                theAM.ChangeBGM(newTrack);
        

        }


    }
}
