using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renpy : MonoBehaviour
{
        [SerializeField] Image img_BG; // ���
        [SerializeField] Image[] img_Character; // ĳ����

        [SerializeField] TextMeshProUGUI Text_Name; // ĳ���� �̸�: ������
        [SerializeField] TextMeshProUGUI Text_Nametitle; // ĳ���� Ÿ��Ʋ
        [SerializeField] TextMeshProUGUI Text_Dialogue; // ���

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
