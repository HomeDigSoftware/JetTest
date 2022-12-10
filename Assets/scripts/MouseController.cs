using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MouseController : MonoBehaviour
{
    public float jetPeckForcs = 75.0f;
    public float forwardMovementSpeed = 3.0f;

    private Rigidbody2D playerRigidbody;

    public Transform groundCheckTransform;
    private bool isGrounded;
    public LayerMask groundCheckLayerMask;
    private Animator mouseAnimator;
    public Button restartButton;

    public ParticleSystem jetpack;
    private bool isDead = false;
    public Text coinsCollectedLabel;

    private uint coins = 0;

    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    void UpdateGroundedStatus()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckTransform.position , 0.1f, groundCheckLayerMask);

        mouseAnimator.SetBool("isGrounded", isGrounded);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Coins"))
        {
            CollectCoin(collider);
        }
        else
        {
            HitByLaser(collider);
        }
 
    }

    



    void HitByLaser (Collider2D laserCollider)
    {
        if (!isDead)
        {
            AudioSource laserZap = laserCollider.gameObject.GetComponent<AudioSource>();
            laserZap.Play();
        }

        isDead = true;
        mouseAnimator.SetBool("isDead", true);

    }
    void CollectCoin(Collider2D coinCollider)
    {
        coins++;
        Destroy(coinCollider.gameObject);
        coinsCollectedLabel.text = coins.ToString();


    }



    void FixedUpdate()
    {
        bool jetpackActive = Input.GetMouseButton(0); 
        jetpackActive = jetpackActive && !isDead ; 

        if (jetpackActive)
        {
            playerRigidbody.AddForce(new Vector2(0, jetPeckForcs));
        }
       
        if(!isDead)
        {
            Vector2 newVelocity = playerRigidbody.velocity;
            newVelocity.x = forwardMovementSpeed;
            playerRigidbody.velocity = newVelocity;         
        }
        
        UpdateGroundedStatus();
        AdjustJetpack(jetpackActive);

        if (isDead && isGrounded)
        {
            restartButton.gameObject.SetActive(true);
        }


    }

    void AdjustJetpack(bool jetpackActive)
    {
        var jetpackEmission = jetpack.emission;
        jetpackEmission.enabled = !isGrounded;
        if (jetpackActive)
        {
            jetpackEmission.rateOverTime = 300f; 

        }
        else
        {
            jetpackEmission.rateOverTime = 75f;

        }
    }
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        mouseAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
