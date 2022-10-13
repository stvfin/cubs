using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cub : MonoBehaviour {
  private float cb_velocity = 2f;         //скорость куба
  private float cb_distance = 20f;        //расстояние до уничтожения
  private Vector3 start_point;            //точка старта

  void Start() {
    start_point = gameObject.transform.position;
    cb_velocity = Main.velocity;
    cb_distance = Main.distance;
    gameObject.GetComponent<Rigidbody>().velocity = new Vector3(1f, 0, 0) * cb_velocity;
  }

  void FixedUpdate() {
    gameObject.GetComponent<Rigidbody>().velocity = new Vector3(1f, 0, 0) * cb_velocity;
    float distance_tm = Vector3.Distance(start_point, transform.position);
    if (distance_tm >= cb_distance) Destroy(gameObject);
  }
}
