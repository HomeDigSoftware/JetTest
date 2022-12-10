using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{

    //1  מוציא החוצה אפשרות לשתי ספרייט שונים 
    public Sprite laserOnSprite;
    public Sprite laserOffSprite;
    //2  נותן אפשרות באינספקטור לברור מהירות הסיבוב והמיתוג (הפעלה)
    public float toggleInterval = 0.5f;
    public float rotationSpeed = 0.0f;
    //3  בודק אם הלייזר מופעל וכמה זמן להפעלה 
    private bool isLaserOn = true;
    private float timeUntilNextToggle;
    //4    ייחוס לקוליידר וראנדראר שנוכל לעבוד איתם בהמשך 
    private Collider2D laserCollider;
    private SpriteRenderer laserRenderer;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextToggle = toggleInterval;
        laserCollider = gameObject.GetComponent<Collider2D>();
        laserRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        timeUntilNextToggle -= Time.deltaTime;

        if (timeUntilNextToggle <= 0)
        {
            isLaserOn = !isLaserOn;
            laserCollider.enabled = isLaserOn;

            if (isLaserOn)
            {
                laserRenderer.sprite = laserOnSprite;
            }
            else
            {
                laserRenderer.sprite = laserOffSprite;
            }
               
            timeUntilNextToggle = toggleInterval;
        }
        transform.RotateAround(transform.position, Vector3.forward, rotationSpeed * Time.deltaTime); 
    }
}











