using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public EnemyMovement enemyMovement; // asigna el enemigo desde el Inspector
    public float playerSpeed;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI enemySpeedText;
    public GameObject endText;

    private Rigidbody rb;
    private int countPoints;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerSpeed = 10;
        countPoints = 0;
        endText.SetActive(false);
        
        SetCountText();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Count: " + countPoints;
        enemySpeedText.text = "Enemy Speed: " + enemyMovement.navMeshAgent.speed;

        if(countPoints > 1)
        {
            endText.GetComponent<TextMeshProUGUI>().color = new Color32(45, 255, 0, 255);
            endText.GetComponent<TextMeshProUGUI>().text = "Ganaste!";
            endText.SetActive(true);
            // Destruir enemigo al ganar
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * playerSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        // if (other.gameObject.CompareTag("PickUp"))
        // {
        other.gameObject.SetActive(false);
        ++countPoints;
        SetCountText();
        // }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the current object
            Destroy(gameObject); 
            // Update the winText to display "You Lose!"
            endText.GetComponent<TextMeshProUGUI>().color = Color.black;
            endText.GetComponent<TextMeshProUGUI>().text = "Perdiste!";
            endText.gameObject.SetActive(true);
        }
    }
}
