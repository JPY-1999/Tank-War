using UnityEngine;

public class Tank_health : MonoBehaviour
{
    public int hp = 100;
    public GameObject tankExplosion;
    public AudioClip tankExpolsionAudio;

    private void makeManages()
    {
        if(hp >= 0)
        {
            hp -= Random.Range(10, 20);
            return;
        }
        else
        {
            AudioSource.PlayClipAtPoint(tankExpolsionAudio,transform.position);
            GameObject.Instantiate(tankExplosion, transform.position + Vector3.up, transform.rotation);
            Destroy(this.gameObject);
        }
    }



}
