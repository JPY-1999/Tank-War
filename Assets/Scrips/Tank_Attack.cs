using UnityEngine;

public class Tank_Attack : MonoBehaviour
{
    public GameObject shellPrefab;
    public float shellSpeed = 10f;
    public KeyCode fireKey; //因为有两个玩家，所以还是得单独定义出来
    public AudioClip shotAudio;

    private Transform firePoint;

    private void Start()
    {
        firePoint = transform.Find("FirePoint");
    }

    private void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab,firePoint.position,firePoint.rotation)as GameObject; //转换为游戏对象后给一个初速度
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
    }
}
