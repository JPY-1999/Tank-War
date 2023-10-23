using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject shellExplosinPrefab;


    public void OnTriggerEnter(Collider collider)
    {
        GameObject.Instantiate(shellExplosinPrefab, transform.position, transform.rotation); //碰撞检测，实例化爆炸效果并销毁子弹
        GameObject.Destroy(this.gameObject);

        if(collider.tag == "Tank")
        {
            collider.SendMessage("makeManages");
        }
    }
}
