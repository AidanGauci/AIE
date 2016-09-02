using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    //public member variables
    public float bulletSpeed;
    public float lifetime;
    public string bulletTag;
    public Sprite playerBullet;
    public Sprite enemyBullet;
    public Vector3 pos;
    

    //private member variables


    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
	}

    void OnCollision(Collision hit)
    {
        if (hit.collider.tag == "Enemy")
        {
            if (bulletTag == "Enemy")
            {

            }
            else if (bulletTag == "Player")
            {
                
            }
        }
        else if (hit.collider.tag == "Player")
        {

        }
        else if (hit.collider.tag == "Cube")
        {

        }
    }
}
