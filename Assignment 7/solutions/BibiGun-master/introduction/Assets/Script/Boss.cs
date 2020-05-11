using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private int direction;
    [SerializeField]
    private float _speed = 1.25f;
    [SerializeField]
    private float _rotateSpeed = 0.3f;
    [SerializeField]
    private Player _player = null;
    private bool _sensor = false;
    private int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
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
        if (other.tag == "Player" && _sensor)
        {
            Destroy(this.gameObject);
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                player.Damage();
                player.Damage();
                player.AddScore();
                player.AddScore();
            }
        }
        if (other.tag == "Laser" && _sensor)
        {
            if (lives > 0) lives = lives - 1;
            if (lives <= 0)
            {
                if (_player != null)
                {
                    print("hit boss");
                    print(lives);
                    _player.AddScore();
                    _player.AddScore();
                }
                Destroy(this.gameObject);
                lives = 3;
            }

        }
    }
    public void SetSensor()
    {
        _sensor = true;
    }
}
