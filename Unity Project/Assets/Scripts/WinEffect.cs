using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinEffect : MonoBehaviour
{
    GameObject emptyObject;
    void Start()
    {
        emptyObject = new GameObject("Particles");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BoundLeft") || collision.gameObject.CompareTag("BoundRight"))
        {
            ParticleSystem explosion = Instantiate(emptyObject, transform.position, Quaternion.identity).AddComponent<ParticleSystem>();
            ExplosionParticles(explosion);
        }
        
    }


    private void ExplosionParticles(ParticleSystem emitter)
    {
        var mainModule = emitter.main;

        mainModule.stopAction = ParticleSystemStopAction.Destroy;
        mainModule.loop = false;
    }
}
