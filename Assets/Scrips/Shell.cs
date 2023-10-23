using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosinPrefab;


    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Instantiate(shellExplosinPrefab, transform.position, transform.rotation); //��ײ��⣬ʵ������ըЧ���������ӵ�
        GameObject.Destroy(this.gameObject);

        if(collider.tag == "Tank")
        {
            collider.SendMessage("makeManages");
        }
    }
}
