using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private float movementX;
    private float movementY;
    [SerializeField] private float speed = 20;

    [SerializeField] private TextMeshProUGUI ñamsText;
    private int ñams = 0;

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
            ñams++;
            ñamsText.text = $"Ñams: {ñams}";

            if (ñams == 8)
            {
                SceneManager.LoadScene("BigWin");
            }
        }
    }
}