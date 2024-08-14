using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class AudioManager : MonoBehaviour
{
    public AudioSource aud;
    public Button muteToggle;
    public Sprite muteSvg;
    public Sprite unmuteSvg;
    public bool isMute;

    // Start is called before the first frame update
    void Start() 
    {
        aud.Play();
        aud.loop = true;
        isMute = false;
        muteToggle.onClick.AddListener(PauseAudio);
        muteToggle.image.sprite = unmuteSvg;
    }


    void Update()
    {
        Debug.Log(isMute);

    }
    

    public void PauseAudio()
    {
        LoadPref();
        
        if (isMute)
        {
            Debug.Log("Mute Pressed");
            aud.Pause();
            muteToggle.image.sprite = muteSvg;
            SavePref(BoolToInt(false));

        }
        else
        {
            Debug.Log("unmute pressed");            
            aud.UnPause();
            muteToggle.image.sprite = unmuteSvg;
            SavePref(BoolToInt(false));
        }

        

    }
    private void SavePref(int bin)
    {
        if (bin is not (0 or 1))
        {
            throw new Exception("This function only accepts binary values of length 1!");
        }
        PlayerPrefs.SetInt("isMute", bin);
        PlayerPrefs.Save();
    
    }

    public void LoadPref()
    {
        if (PlayerPrefs.HasKey("isMute"))
        {
            isMute = INTToBool(PlayerPrefs.GetInt("HighScore"));
        }
        else
        {
            isMute = INTToBool(1);
        }

    }

    bool INTToBool(int num)
    {
        if (num == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
        
    }

    int BoolToInt(bool b)
    {
        if (b)
        {
            return 1;
        }

        else
        {
            return 0;
        }
    }
}
