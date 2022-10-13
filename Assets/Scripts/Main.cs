using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour {
  public GameObject panel_main;
  public GameObject panel_menuset;
  public Text txt_interval;                   //поле ввода интервал
  public Text txt_velocity;                   //поле ввода скорость
  public Text txt_distance;                   //поле ввода расстояние

  public static float interval = 4f;          //интервал запуска
  public static float velocity = 6;           //скорость куба
  public static float distance = 20f;          //расстояние до уничтожения

  void Start() {
    panel_main.SetActive(true);
    panel_menuset.SetActive(false);
    txt_interval.text = interval.ToString("0.0");
    txt_velocity.text = velocity.ToString("0.0");
    txt_distance.text = distance.ToString("0.0");
  }

  void Update() {

  }

  public void btn_setup() {
    Time.timeScale = 0;
    panel_menuset.SetActive(true);
    panel_main.SetActive(false);
  }

  public void btn_setok() {
    Time.timeScale = 1;
    var cultureInfo = CultureInfo.InvariantCulture;
    NumberStyles styles = NumberStyles.Number;
    float set_interval;
    if (float.TryParse(txt_interval.text, styles, cultureInfo, out set_interval)) 
      if (set_interval>0) interval = set_interval;
    float set_velocity;
    if (float.TryParse(txt_velocity.text, styles, cultureInfo, out set_velocity)) 
      if (set_velocity>0) velocity = set_velocity;
    float set_distance;
    if (float.TryParse(txt_distance.text, styles, cultureInfo, out set_distance)) 
      if (set_distance>0) distance = set_distance;
    Debug.Log("BTN OK int=" + interval.ToString("0.0") + " vel=" + velocity.ToString("0.0") + " dist=" + distance.ToString("0.0"));
    panel_menuset.SetActive(false);
    panel_main.SetActive(true);
  }
  public void btn_secan() {
    Time.timeScale = 1;
    panel_main.SetActive(true);
    panel_menuset.SetActive(false);
  }
}
