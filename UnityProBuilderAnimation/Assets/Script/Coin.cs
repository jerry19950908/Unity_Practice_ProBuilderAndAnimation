using UnityEngine;

public class Coin : MonoBehaviour
{
    [Header("金幣")]
    public GameObject coin;
    [Header("音效")]
    public AudioSource aud;
    public AudioClip soundcoin;

    
    
    public void Producecoin()
    {
        
        Instantiate(coin);
        aud.PlayOneShot(soundcoin, 1.5f);

       
    }

}
