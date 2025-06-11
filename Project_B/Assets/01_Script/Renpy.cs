using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
        [SerializeField] Image img_BG; // 배경
        [SerializeField] Image[] img_Character; // 캐릭터

        [SerializeField] TextMeshProUGUI Text_Name; // 캐릭터 이름: 여행자
        [SerializeField] TextMeshProUGUI Text_Nametitle; // 캐릭터 타이틀
        [SerializeField] TextMeshProUGUI Text_Dialogue; // 대사

    int id = 1;

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character;
        Text_Name.text = SData.GetCharacterData(characterID).Name;
        Text_Nametitle.text = SData.GetCharacterData(characterID).Title;

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;

    }

}
