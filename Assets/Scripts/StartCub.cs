using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCub : MonoBehaviour {
  public GameObject myCub;    //Префаб Куба
  public float interval=5f;    //интервал в секундах

  void Start() {
    interval = Main.interval;
    InvokeRepeating("CreateCub", 0, interval);
  }

  void Update() {
  }

  void CreateCub() {
    GameObject clone = Instantiate(myCub, new Vector3(transform.position.x+0.5f, transform.position.y, transform.position.z), Quaternion.identity);
    if (interval != Main.interval) {
      CancelInvoke("CreateCub");
      interval = Main.interval;
      InvokeRepeating("CreateCub", interval, interval);
    }
  }
}
