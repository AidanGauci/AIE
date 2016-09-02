using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float fireRate = 2f;
	public int attackDamage = 1;
	public int health = 2;
	public Transform bulletSpawnPos;
	public GameObject bullet;
	public int currentDirection;
	public GameObject spawnControl;
	public int LayerID;

	public float verticalTimeDelay = 5f;
	public float maxVerticalTimeDelay = 5f;
	private float fireDelay;
	private Spawning spawnLink;

	// Use this for initialization
	void Start () {
		fireDelay = Random.Range (1, 5);
		Invoke("FireBullet", fireDelay);
		spawnLink = spawnControl.GetComponent<Spawning>();
	}
	
	// Update is called once per frame
	void Update () {
		verticalTimeDelay -= Time.deltaTime;
		if (health == 0)
		{
			spawnLink.aliveEnemies--;
			Destroy (this);
		}
	}

	void FireBullet()
	{
		Debug.Log ("Fire");
		//Instantiate (bullet, bulletSpawnPos.position, Quaternion.identity);
		Invoke("FireBullet", fireRate);
	}

	IEnumerator MoveDown()
	{
		verticalTimeDelay = maxVerticalTimeDelay;
		Vector3 newPos = transform.position + new Vector3 (0, -0.5f, 0);
		float t = 0;
		float step = (1 / (transform.position - newPos).magnitude) * Time.fixedDeltaTime;
		while (t <= 1.0f)
		{
			t += step;
			transform.position += Vector3.down * Time.deltaTime;
			yield return new WaitForFixedUpdate();
		}
		newPos.x = transform.position.x;
		transform.position = newPos;
	}
}
