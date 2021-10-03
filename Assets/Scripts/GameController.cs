using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public AudioClip musicClipOne;
	public AudioClip musicClipTwo;
	public AudioSource musicSource;

	private Animator anim;
	private int currentTrack;

	private void Start()
	{
		anim = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}

		
		if (Input.GetKeyDown(KeyCode.W))
		{
			musicSource.clip = musicClipOne;
			musicSource.Play();
			currentTrack = 1;
			anim.SetInteger("State", 1);
		}

		if (Input.GetKeyDown(KeyCode.R))
		{
			musicSource.clip = musicClipTwo;
			musicSource.Play();
			currentTrack = 2;
			anim.SetInteger("State", 2);
		}

		if (musicSource.isPlaying)
		{
			if (((currentTrack == 1) && Input.GetKeyUp(KeyCode.W) ) || ((currentTrack == 2) && Input.GetKeyUp(KeyCode.R)))
			{
				musicSource.Stop();
				anim.SetInteger("State", 0);
			}
		}
	}
}
