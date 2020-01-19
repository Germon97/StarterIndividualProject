using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PESMTextKill : MonoBehaviour
{

	public AudioClip newTrack;
	public AudioClip loseTrack;

	public static float startTime = 2f;
	private float count =0;

	private AudioManager theAM;

		// Use this for initialization
	void Start()
	{
		Destroy(gameObject, 2);
		theAM = FindObjectOfType<AudioManager>();
	}

	// Update is called once per frame
	void Update()
	{
		startTime -= Time.deltaTime;
		count = count + Time.deltaTime;
		if (startTime < 0)
        {
			startTime = 0;
		if(newTrack != null)
		theAM.ChangeBGM(newTrack);
        }
		if (count >= 12)
		{
			if (loseTrack != null)
			theAM.ChangeBGM(loseTrack);

		}
		
			

	}
			
			

		
}