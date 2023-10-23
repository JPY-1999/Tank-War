using UnityEngine;

public class Tank_Attack : MonoBehaviour
{
    public GameObject shellPrefab;
    public float shellSpeed = 10f;
    public KeyCode fireKey; //��Ϊ��������ң����Ի��ǵõ����������
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
            GameObject go = GameObject.Instantiate(shellPrefab,firePoint.position,firePoint.rotation)as GameObject; //ת��Ϊ��Ϸ������һ�����ٶ�
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
    }
}
