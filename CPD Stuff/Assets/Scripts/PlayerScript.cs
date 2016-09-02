using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    //public member variables
    public int health = 5;
    public float speed = 5;
    public float fireRate = 1;
    public Text scoreOutput;
    public BulletScript bullet;

    //private member variables
    private Vector3 pos = new Vector3(0, -3, 0);
    private Vector3 prevPos = new Vector3(0, -3, 0);
    private int score = 0;
    private int m_direction = 0;
    private bool leftPress = false;
    private bool rightPress = false;
    private float screenHalfWidthInWorldUnits;
	
    //used to initialize shtuff
    void Start()
    {
        float halfSelfWidth = transform.localScale.x / 2;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize - halfSelfWidth;
    }

	// Update is called once per frame
	void Update ()
    {
        //end-game stuff
        if (health <= 0)// || end-game constraints met)
        {
            EndGame();
        }

        //moves player and keeps them in screen
        prevPos = transform.position;
        if (leftPress || rightPress)
        {
            if (transform.position.x > -screenHalfWidthInWorldUnits && transform.position.x < screenHalfWidthInWorldUnits)
            {
                MovePlayer(m_direction);
            }
            if (transform.position.x < -screenHalfWidthInWorldUnits || transform.position.x > screenHalfWidthInWorldUnits)
            {
                transform.position = prevPos;
            }
        }
	}
    //shoots bullet from player
    public void FireShot(int shoot)
    {
        
    }

    //moves player according to button input
    void MovePlayer(int direction)
    {
        
        if (direction == -1)
        {
            
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (direction == 1)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {

        }
    }

    //SwitchOn and SwitchOff both used to move player
    public void SwitchOff(int direction)
    {
        if (direction == -1)
        {
            leftPress = false;
        }
        else if (direction == 1)
        {
            rightPress = false;
        }
    }

    public void SwitchOn(int direction)
    {
        if (direction == -1)
        {
            leftPress = true;
        }
        else if (direction == 1)
        {
            rightPress = true;
        }
        m_direction = direction;
    }

    //calls end game screen when out of health
    void EndGame()
    {
        
    }

   
}
