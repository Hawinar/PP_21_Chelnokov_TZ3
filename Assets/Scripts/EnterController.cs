using UnityEngine;

public class EnterController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (this.gameObject.tag)
        {
            case "Coin":
                if (collision.tag == "Player")
                {
                    GameManager.Coins++;
                    Destroy(this.gameObject);;
                }
                break;
            case "Finish":
                if (collision.tag == "Player")
                {
                    GameManager.Lap++;
                }
                break;
        }
    }
}