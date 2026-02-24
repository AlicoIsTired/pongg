using UnityEngine;

public class Script : MonoBehaviour
{
    [SerializeField] Transform PaddleLeft;
    [SerializeField] Transform PaddleRight;
    [SerializeField] float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {

    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleLeft.position;
            newPosition.y -= Speed;
            PaddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleLeft.position;
            newPosition.y += Speed;
            PaddleLeft.position = newPosition;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleRight.position;
            newPosition.y -= Speed;
            PaddleRight.position = newPosition;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("aa");
            Vector3 newPosition = PaddleRight.position;
            newPosition.y += Speed;
            PaddleRight.position = newPosition;
        }
    }
}
