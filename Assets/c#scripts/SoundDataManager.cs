using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundDataManager : MonoBehaviour
{
    public Slider BGM;
    public Slider SFX;


    // Start is called before the first frame update
    void Start()
    {
        //���� ������ �� ���� �����͸� �ҷ����� �����ؾ� �Ѵ�.
        //����ͼ� ���� ����� ���� ����ְ� ��������.

            BGM.value = PlayerPrefs.GetFloat("FILE_BGM_Sound");
            SFX.value = PlayerPrefs.GetFloat("FILE_SFX_Sound");

    }
    //void OnEnable()
    //{
    //    BGM.value = BGM_Save;
        
    //}
    // Update is called once per frame
    void OnDisable()
    {
        PlayerPrefs.SetFloat("FILE_BGM_Sound", BGM.value);
        PlayerPrefs.SetFloat("FILE_SFX_Sound", SFX.value);
    }

}
