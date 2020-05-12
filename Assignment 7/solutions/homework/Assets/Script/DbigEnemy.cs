using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbigEnemy : MonoBehaviour
{

    // Start is called before the first frame update

    private int bigcCowLife = 10;
    private int direction;
    [SerializeField]
    private float _speed = 1.25f;
    [SerializeField]
    private float _rotateSpeed = 0.3f;
    [SerializeField]
    private Player _player = null;
    private bool _sensor = false;

    // Start is called before the first frame update

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("police");
        try
        {
            _player = GameObject.Find("Player").GetComponent<Player>();
        }
        catch (System.Exception e)
        {
            Debug.LogWarning("player not found");
        }
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0, -1 * _speed * Time.unscaledDeltaTime, 0);
        if (direction == 1)
            transform.Rotate(Vector3.forward * _rotateSpeed);
        else
            transform.Rotate(Vector3.back * 0.3f);
        if (transform.position.y < -7f)
        {
            float randomized = Random.Range(-8.0f, 8.0f);
            transform.position = new Vector3(randomized, 9, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {

            bigcCowLife--;
            Destroy(other.gameObject);
            if(bigcCowLife < 1)
            {
                Destroy(this.gameObject);
                FindObjectOfType<AudioManager>().Stop("police");
                if (_player != null)
                    _player.AddScore();
            }
        }
        if (other.tag == "Player" && _sensor)
        {
            Destroy(this.gameObject);
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                FindObjectOfType<AudioManager>().Stop("police");
                player.Damage();
                player.Damage();
                player.AddScore();
                player.AddScore();

            }
        }
    }
    public void SetSensor()
    {
        _sensor = true;
    }

}
