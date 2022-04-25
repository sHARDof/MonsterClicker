using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public bool Check;
    private int MoneyUpCost1 = 100;
    private int MoneyUpCost2 = 300;
    public int UpMoney = 1;
    public int Money = 0;
    public int Damage = 1;
    public int DamageUp1 = 1;
    public int DamageUp2 = 2;
    public int Level = 1;
    public int HPlevel1 = 5;
    public int HPlevel2 = 10;
    public int HPlevel3 = 20;
    public int HPlevel4 = 50;
    public int HPlevel5 = 100;
    public int kills = 0;
    public Text TextMoney;
    public Text TextCostUp1;
    public Text TextCostUp2;
    public Text TextHP;
    public Text TextLevel;
    public Text TextDamage;
    public Text TextLevelNumber;
    public GameObject PanelShop;
    public GameObject PanelLevel5;
    public GameObject PanelLevel4;
    public GameObject PanelLevel3;
    public GameObject PanelLevel2;
    public GameObject PanelLevel1;
    public GameObject PanelMenu;
    public GameObject PanelAwards;
    public GameObject PanelMoney;
    public GameObject PanelKills;
    public AudioClip ClickMonsterMusic;
    public AudioSource MusicClick;
    public AudioSource MusicClick2;
    public AudioSource MusicClick3;
    public AudioSource MusicClick4;
    public AudioSource MusicClick5;

    void Update()
    {
        
        TextMoney.text = Money + "";

        TextCostUp1.text = "Cost: " + MoneyUpCost1 + "";

        TextCostUp2.text = "Cost: " + MoneyUpCost2 + "";

        TextDamage.text = Damage + "";

        if (kills==100)
        {
            PanelKills.SetActive(true);
        }

        if (Money==100)
        {
            PanelMoney.SetActive(true);
        }

        if (HPlevel1==0)
        {
            HPlevel1 +=5;
            Level++;
            kills++;
        }
        if (HPlevel2 == 0)
        {
            HPlevel2+=10;
            Level++;
            kills++;
        }

        if (HPlevel3 == 0)
        {
            HPlevel3 += 20;
            Level++;
            kills++;
        }

        if (HPlevel4 == 0)
        {
            HPlevel4 +=50;
            Level++;
            kills++;
        }

        if (HPlevel5 == 0)
        {
            HPlevel5 +=100;
            Level++;
            kills++;
        }

        if (HPlevel1-Damage < 0)
        {
            HPlevel1 = 0;
        }

        if (HPlevel2 - Damage < 0)
        {
            HPlevel2 = 0;
        }

        if (HPlevel3 - Damage < 0)
        {
            HPlevel3 = 0;
        }

        if (HPlevel4 - Damage < 0)
        {
            HPlevel4 = 0;
        }

        if (HPlevel5 - Damage < 0)
        {
            HPlevel5 = 0;
        }

        if (PanelLevel1.active == true)
        {
            TextLevelNumber.text = "1";
            TextHP.text = "HP: " + HPlevel1;
        }

        if (PanelLevel2.active == true)
        {
            TextLevelNumber.text = "2";
            TextHP.text = "HP: " + HPlevel2;
        }
        if (PanelLevel3.active == true)
        {
            TextLevelNumber.text = "3";
            TextHP.text = "HP: " + HPlevel3;
        }

        if (PanelLevel4.active == true)
        {
            TextLevelNumber.text = "4";
            TextHP.text = "HP: " + HPlevel4;
        }

        if (PanelLevel5.active == true)
        {
            TextLevelNumber.text = "Boss";
            TextHP.text = "HP: " + HPlevel5;
        }

    }
    public void ClickMonster()
    {
        Money += UpMoney;
        if (PanelLevel1.active == true)
        {
            HPlevel1 -= Damage;
            MusicClick.PlayOneShot(ClickMonsterMusic);
        }
        if (PanelLevel2.active == true)
        {
            MusicClick2.PlayOneShot(ClickMonsterMusic);
        }
        if (PanelLevel3.active == true)
        {
            MusicClick3.PlayOneShot(ClickMonsterMusic);
        }
        if (PanelLevel4.active == true)
        {
            MusicClick4.PlayOneShot(ClickMonsterMusic);
        }
        if (PanelLevel5.active == true)
        {
            MusicClick5.PlayOneShot(ClickMonsterMusic);
        }
    }

    public void ClickUpgrade1()
    {
        if (Money >= MoneyUpCost1)
        {
            Money -= MoneyUpCost1;
            MoneyUpCost1 *= 2;
            Damage += DamageUp1;
        }
    }

    public void ClickUpgrade2()
    {
        if (Money >= MoneyUpCost2)
        {
            Money -= MoneyUpCost2;
            MoneyUpCost2 *= 2;
            Damage += DamageUp2;
        }
    }

    public void ClickNext()
    {
        if (TextLevelNumber.text == "1" )
        {
            PanelLevel1.SetActive(false);
            PanelLevel2.SetActive(true);
        }
        if (TextLevelNumber.text == "2" )
        {
            PanelLevel2.SetActive(false);
            PanelLevel3.SetActive(true);
        }
        if (TextLevelNumber.text == "3")
        {
            PanelLevel3.SetActive(false);
            PanelLevel4.SetActive(true);
        }
        if (TextLevelNumber.text == "4" )
        {
            PanelLevel4.SetActive(false);
            PanelLevel5.SetActive(true);
        }

    }

    public void ClickBack()
    {
        if (PanelLevel2.active == true)
        {
            PanelLevel2.SetActive(false);
            PanelLevel1.SetActive(true);
        }
        if (PanelLevel3.active == true)
        {
            PanelLevel3.SetActive(false);
            PanelLevel2.SetActive(true);
        }
        if (PanelLevel4.active == true)
        {
            PanelLevel4.SetActive(false);
            PanelLevel3.SetActive(true);
        }
        if (PanelLevel5.active == true)
        {
            PanelLevel5.SetActive(false);
            PanelLevel4.SetActive(true);
        }
    }

    public void ClickMonsterLevel2()
    {
        Money += UpMoney + 1;
        HPlevel2 -= Damage;
    }

    public void ClickMonsterLevel3()
    {
        Money += UpMoney + 2;
        HPlevel3 -= Damage;
    }

    public void ClickMonsterLevel4()
    {
        Money += UpMoney + 4;
        HPlevel4 -= Damage;
    }
    public void ClickMonsterLevel5()
    {
        Money += UpMoney + 10;
        HPlevel5 -= Damage;
    }

    public void OnClickMenu()
    {
        PanelMenu.SetActive(true);
    }

    public void OnCloseButton()
    {
        PanelMenu.SetActive(false);
    }

    public void OnCloseGame()
    {
        Application.Quit();
    }

    public void OnMuteMusic()
    {
        AudioListener.volume = 0f;
    }

    public void OnOpenMusic()
    {
        AudioListener.volume = 1f;
    }

    public void OnClicAward()
    {
        PanelAwards.SetActive(true);
        PanelMenu.SetActive(false);
    }

    public void ExitButton()
    {
        PanelAwards.SetActive(false);
    }
}
