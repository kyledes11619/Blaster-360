using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_script : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public GameObject EnemyDeath;
    public Transform EnemyDeathTransform;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("Collision Detected");

        if (source != null && clip != null)
        {
            source.PlayOneShot(clip);
            Destroy(gameObject, 0.1f);
            Instantiate(EnemyDeath, EnemyDeathTransform);
        }



    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
