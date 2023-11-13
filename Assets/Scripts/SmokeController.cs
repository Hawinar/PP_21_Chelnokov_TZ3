using UnityEngine;

public class SmokeController : MonoBehaviour
{
    private void Update()
    {
        this.transform.localScale = new Vector2(this.transform.localScale.x + 0.05f * Time.deltaTime, this.transform.localScale.y + 0.05f * Time.deltaTime);
        if (this.transform.localScale.x >= 0.75)
            Destroy(this.gameObject);
    }
}