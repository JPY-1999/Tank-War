using UnityEngine;

public class DestoryShellTime : MonoBehaviour
{
    public float time = 1.5f;

    private void Start()
    {
        Destroy(this.gameObject, time);
    }
}
