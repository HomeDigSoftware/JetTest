using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class voicCommend : MonoBehaviour
{
    public float jetPeckForcs = 50.0f;
    private Dictionary<string, Action> keyWordAction = new Dictionary<string, Action>();
    private KeywordRecognizer KeywordRecognizer;
    private Rigidbody2D playerRigidbody;

    void Start()
    {

        playerRigidbody = gameObject.GetComponent<Rigidbody2D>();
        keyWordAction.Add("go down", goDown);

        keyWordAction.Add("go up", goup);


        

        KeywordRecognizer = new KeywordRecognizer(keyWordAction.Keys.ToArray());
        KeywordRecognizer.OnPhraseRecognized += OnKeywordRecognized;
        KeywordRecognizer.Start();
    }

    private void OnKeywordRecognized(PhraseRecognizedEventArgs args)
    {
        Debug.Log("ketword:" + args.text);
        keyWordAction[args.text].Invoke();
    }
    private void goDown()
    {
        transform.position = new Vector3(0, -2, 0);
        Debug.Log("you say i do sir jummmmmmmmmmmmpppppppppppppppppppppppp");
    }
    private void goup()
    {
        Debug.Log("you say i do sir  shoooot");
        transform.position = new Vector3(0, 2, 0);
    }
    private void shoot()
    {
        Debug.Log("you say i do sir  booooooooooooooooooooooommm");
    }
    private void boom()
    {
        Debug.Log("you say i do sir  booooooooooooooooooooooommm");
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

        
        playerRigidbody.AddForce(new Vector2(0, jetPeckForcs));
        Vector2 newVelocity = playerRigidbody.velocity;
        newVelocity.x = 3f;
        playerRigidbody.velocity = newVelocity;
         }
    }
}
