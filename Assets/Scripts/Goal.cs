using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public AudioClip goalClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            var audioSource = GetComponent<AudioSource>();
            if (audioSource != null && goalClip != null)
            {
                audioSource.PlayOneShot(goalClip);
            }
            GameManager.instance.RestartLevel(0.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
