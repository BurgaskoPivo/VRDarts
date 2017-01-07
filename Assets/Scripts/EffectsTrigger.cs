using UnityEngine;
using System.Collections;

public class EffectsTrigger : MonoBehaviour
{
    private AudioSource audio;

    void Start()
    {
        this.audio = this.gameObject.GetComponent<AudioSource>();
    }

    public void Run()
    {
        this.audio.Play();
    }
}
