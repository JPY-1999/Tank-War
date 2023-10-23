using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    private Vector3 offset;
    private new Camera camera;

    private void Start()
    {
        offset = transform.position - (player1.position + player2.position) / 2;
        camera = this.GetComponent<Camera>();
    }

    private void Update()
    {
        if(player1 == null || player2 == null)
        {
            return;
        }
        transform.position = (player1.position + player2.position)/2 + offset;
        float distance = Vector3.Distance(player1.position, player2.position);

        if (distance < 5f)
        {
            return;
        }

        float size = distance * 0.875f;
        camera.orthographicSize = size;
    }

}
