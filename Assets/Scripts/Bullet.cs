using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

  public float bulletSpeed = 10;
  public float bulletDamage;

  public float maxTimeAlive;

    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(SelfDestruct());
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
      this.transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);
      {

      }
    }

    IEnumerator SelfDestruct()
    {
      yield return new WaitForSeconds(maxTimeAlive);
      Destroy(this.gameObject);
    }
}
