using UnityEngine;
using System.Collections;

public class HitManager : MonoBehaviour
{

    public int Points = 10;
    public EffectsTrigger audioPlayer;
    public ParticleSystem explosion;


    void OnTriggerEnter(Collider other)
    {
        ScoreManager.Score += this.Points;
        this.audioPlayer.Run();
        this.explosion.gameObject.transform.parent = this.transform.parent.parent;
        this.explosion.Play();
        Destroy(this.gameObject.transform.parent.gameObject);
    }

}
