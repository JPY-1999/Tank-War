using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Movement : MonoBehaviour
{
    public float speed = 5f;
    public float angularSpeed = 5f;
    public int number = 1;
    public AudioClip idleAudio;
    public AudioClip drivingAudio;

    private new AudioSource audio;

    private new Rigidbody rigidbody;

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        audio = this.GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Verticalp"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("Horizontalp"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        if(Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audio.clip = drivingAudio;
            if(audio.isPlaying == false)
            {
                audio.Play();
            }else
            {
                audio.clip = idleAudio;
                if(audio.isPlaying == false)
                {
                    audio.Play();
                }
            }
        }
        
    }
}
