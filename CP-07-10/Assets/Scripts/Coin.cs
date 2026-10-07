using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] GameObject coin;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            collision.gameObject.GetComponent<text>().AddCoin();
        }
    }
}