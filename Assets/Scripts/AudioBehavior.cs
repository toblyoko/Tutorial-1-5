using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBehavior : MonoBehaviour
{
	public AudioClip musicClipOne;
	public AudioClip musicClipTwo;
	public AudioSource musicSource;

	private int currentTrack;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}

		if (!musicSource.isPlaying)
		{
			if (Input.GetKeyDown(KeyCode.W))
			{
				musicSource.clip = musicClipOne;
				musicSource.Play();
				currentTrack = 1;
			}
			else if (Input.GetKeyDown(KeyCode.R))
			{
				musicSource.clip = musicClipTwo;
				musicSource.Play();
				currentTrack = 2;
			}
		}
		else
		{
			if ((currentTrack == 1) && Input.GetKeyUp(KeyCode.W))
			{
				musicSource.Stop();
			}
			else if ((currentTrack == 2) && Input.GetKeyUp(KeyCode.R))
			{
				musicSource.Stop();
			}
		}
	}
}
