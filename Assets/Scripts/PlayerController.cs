using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _userDirection;
    [SerializeField] private GameObject _smoke;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _userDirection = new Vector3(0, 1, 0);
    }

    private void Update()
    {
        if (_player != null)
        {
            _player?.transform.Translate(_userDirection * 2f * Time.deltaTime);
            if (_player?.GetComponent<Animator>() == null)
                _player?.transform.Rotate(new Vector3(0, 0, -0.01f));
        }

    }

    private void OnMouseDrag()
    {
        if (_player != null)
        {
            Destroy(_player?.GetComponent<Animator>());

            _player?.transform.Rotate(new Vector3(0, 0, 0.75f));
            Instantiate(_smoke, _player.transform.position, _player.transform.rotation);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grass")
        {
            Destroy(_player);
        }
        if (collision.gameObject.tag == "Coin")
        {
            GameManager.Coins++;
        }
    }

    private void OnDestroy()
    {
        GameManager.Coins = 0;
        if (GameManager.Best < GameManager.Lap)
            GameManager.Best = GameManager.Lap;
        SaveResults.Save();
        GameManager.Lap = 0;
    }

}