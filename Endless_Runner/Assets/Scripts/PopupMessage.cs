using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PopupMessage : MonoBehaviour {
    public GameObject ui;
    public Texture GameOverTexture;
    public void Open(string inventoryStuffName, string message,string message_2){
        Debug.Log(ui.activeSelf);
        ui.SetActive (!ui.activeSelf);
        if (ui.activeSelf) {
            if(!string.IsNullOrEmpty(inventoryStuffName)){
                Debug.Log(inventoryStuffName);
                RawImage rawImage = ui.gameObject.GetComponentInChildren<RawImage>();
                rawImage.texture = GameOverTexture;
            }
            if (!string.IsNullOrEmpty (message)) {
                Text[] textObject = ui.gameObject.GetComponentsInChildren<Text> ();
                textObject[0].text = message;
                textObject[1].text = message_2;
            }
            Time.timeScale = 0f;
        } 
    }
    public void Close(){
        ui.SetActive (!ui.activeSelf);
        if (!ui.activeSelf) {
            Time.timeScale = 1f;
        } 
        SceneManager.LoadScene ("SampleScene");
    }
//You need to have Folder Resources/InvenotryItems
}