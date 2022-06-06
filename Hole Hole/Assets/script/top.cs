using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class top : MonoBehaviour {
    public int basla;
    public float hiz;
    public int puan;
    public int dokunmak;
    Vector3 top_ilkonum;
    Vector3 dokunmak_ilkonum;
    public GameObject butonlar;
    public GameObject oyunsonu_paneli;
    public AudioClip[] sesdosyaları;
    public GameObject[] satır2;
    public GameObject[] satır3;
    public GameObject[] satır4;
    public GameObject[] satır5;
    public GameObject[] satır6;
    public GameObject[] satır7;
    public GameObject[] satır8;
    public GameObject[] satır9;
    public GameObject[] satır10;
    public GameObject[] satır11;
    public GameObject[] satır12;
    public GameObject[] satır13;
    public GameObject[] satır14;
    public GameObject[] satır15;
    public GameObject[] satır16;
    public GameObject[] satır17;
    public GameObject[] satır18;
    public GameObject[] satır19;
    public GameObject[] satır20;
    public GameObject[] satır21;
    public GameObject[] satır22;
    public GameObject[] satır23;
    public GameObject[] satır24;
    public GameObject[] satır25;
    public GameObject bolumbitti_paneli;
    int rastgele_obje;  
    int gecicisayi;
    public Text level_texti;
    public Text sonraki_level_texti;
    public Text puantexti;
    public Text bestskor_texti;
    public GameObject bestskor_objesi;
    public Text yuzdekactamam_sonuc;
    public Text yuzdekactamam_sonuc_bolumbitti;
    public Slider yuzde_kac_ibresi;
    public GameObject[] satırlar;
    public int gecici_sayma_Sayisi;
    public Color[] newColor;
    public GameObject background;
    public GameObject newskor_paneli;
    public Text level_gecildi_yazisi;
    void Start()
    {
        if (PlayerPrefs.GetInt("level") != PlayerPrefs.GetInt("levelgecici"))
        {
            PlayerPrefs.SetInt("bestskor", 0);
            PlayerPrefs.SetInt("levelgecici", PlayerPrefs.GetInt("level"));
        }
        if (PlayerPrefs.GetInt("bestskor") != 0)
        {
            bestskor_objesi.SetActive(true);
            bestskor_texti.text = "best : " + PlayerPrefs.GetInt("bestskor").ToString();
        }
        if (PlayerPrefs.GetInt("bestskor") == 0)
        {
            bestskor_objesi.SetActive(false);
            
        }

        //WithForeachLoop();
        newColor[0] = Color.black;
        newColor[1] = Color.cyan;
        newColor[2] = Color.blue;
        newColor[3] = Color.green;
        newColor[4] = Color.white;
        newColor[5] = Color.yellow;
        newColor[6] = Color.red;
        
        renk_random();
        if (PlayerPrefs.GetInt("gecici")==0)
        {
            PlayerPrefs.SetInt("level",1);
            PlayerPrefs.SetInt("levelgecici", 1);
            PlayerPrefs.SetInt("gecici", 1);
        }
        
        if (PlayerPrefs.GetInt("level") < 4)
        {
            if (Application.loadedLevelName != "kolay bolum")
            {
                SceneManager.LoadSceneAsync("kolay bolum");
            }
        }
        else
        {
            if (Application.loadedLevelName != "zor_bolum")
            {
                SceneManager.LoadSceneAsync("zor_bolum");
            }
        }
        level_texti.text = PlayerPrefs.GetInt("level").ToString();
        sonraki_level_texti.text = (PlayerPrefs.GetInt("level")+1).ToString();
        Time.timeScale = 1;
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır2[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[0].transform.position = new Vector3(XPoz, satırlar[0].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır2[i].SetActive(false);
            }
        }
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır3[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[1].transform.position = new Vector3(XPoz, satırlar[1].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır3[i].SetActive(false);
            }
        }
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır4[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[2].transform.position = new Vector3(XPoz, satırlar[2].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır4[i].SetActive(false);
            }
        }

        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır5[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[3].transform.position = new Vector3(XPoz, satırlar[3].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır5[i].SetActive(false);
            }
        }
    }
    public void rastgele_6()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır6[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[4].transform.position = new Vector3(XPoz, satırlar[4].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır6[i].SetActive(false);
            }
        }
    }
        public void rastgele_7()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır7[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[5].transform.position = new Vector3(XPoz, satırlar[5].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır7[i].SetActive(false);
            }
        }
    }
        public void rastgele_8()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır8[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[6].transform.position = new Vector3(XPoz, satırlar[6].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır8[i].SetActive(false);
            }
        }
    }
        public void rastgele_9()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır9[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[7].transform.position = new Vector3(XPoz, satırlar[7].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır9[i].SetActive(false);
            }
        }
    }
        public void rastgele_10()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır10[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[8].transform.position = new Vector3(XPoz, satırlar[8].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır10[i].SetActive(false);
            }
        }
    }
        public void rastgele_11()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır11[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[9].transform.position = new Vector3(XPoz, satırlar[9].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır11[i].SetActive(false);
            }
        }
    }

        public void rastgele_12()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır12[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[10].transform.position = new Vector3(XPoz, satırlar[10].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır12[i].SetActive(false);
            }
        }
    }
        public void rastgele_13()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır13[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[11].transform.position = new Vector3(XPoz, satırlar[11].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır13[i].SetActive(false);
            }
        }
    }
        public void rastgele_14()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır14[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[12].transform.position = new Vector3(XPoz, satırlar[12].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır14[i].SetActive(false);
            }
        }
    }
        public void rastgele_15()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır15[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[13].transform.position = new Vector3(XPoz, satırlar[13].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır15[i].SetActive(false);
            }
        }
    }

        public void rastgele_16()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır16[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[14].transform.position = new Vector3(XPoz, satırlar[14].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır16[i].SetActive(false);
            }
        }
    }
        public void rastgele_17()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır17[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[15].transform.position = new Vector3(XPoz, satırlar[15].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır17[i].SetActive(false);
            }
        }
    }

        public void rastgele_18()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır18[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[16].transform.position = new Vector3(XPoz, satırlar[16].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır18[i].SetActive(false);
            }
        }
    }
        public void rastgele_19()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır19[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[17].transform.position = new Vector3(XPoz, satırlar[17].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır19[i].SetActive(false);
            }
        }
    }
        public void rastgele_20()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır20[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[18].transform.position = new Vector3(XPoz, satırlar[18].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır20[i].SetActive(false);
            }
        }

        }
        public void rastgele_21()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır21[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[19].transform.position = new Vector3(XPoz, satırlar[19].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır21[i].SetActive(false);
            }
        }
    }
        public void rastgele_22()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır22[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[20].transform.position = new Vector3(XPoz, satırlar[20].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır22[i].SetActive(false);
            }
        }
    }
        public void rastgele_23()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır23[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[21].transform.position = new Vector3(XPoz, satırlar[21].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır23[i].SetActive(false);
            }
        }
    }

        public void rastgele_24()
    {
        rastgeleobje_ac();
        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır24[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[22].transform.position = new Vector3(XPoz, satırlar[22].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır24[i].SetActive(false);
            }
        }
    }
    public void rastgele_25()
    {
        rastgeleobje_ac();



        for (int i = 0; i < 7; i++)
        {
            if (i == rastgele_obje)
            {
                satır25[i].SetActive(true);
                if (i == 0)
                {
                    float XPoz = Random.Range(-476.67f, -461.7f);
                    satırlar[23].transform.position = new Vector3(XPoz, satırlar[23].transform.position.y, transform.position.z);

                }
            }
            else
            {
                satır25[i].SetActive(false);
            }
        }
    

    

}
	public void rastgeleobje_ac()
    {


        if (PlayerPrefs.GetInt("level") <= 5)
        {
           
         rastgele_obje = 0;
           
        }
        else if (PlayerPrefs.GetInt("level") > 5 && PlayerPrefs.GetInt("level") <= 10)
        {
            rastgele_obje = Random.Range(0, 1);

            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 1);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 2)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }
        }
        else if (PlayerPrefs.GetInt("level") > 10 && PlayerPrefs.GetInt("level") <= 15)
        {
            rastgele_obje = Random.Range(0, 2);

            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 2);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 3)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }
        }
        else if (PlayerPrefs.GetInt("level") > 15 && PlayerPrefs.GetInt("level") <= 20)
        {
            rastgele_obje = Random.Range(0, 3);

            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 3);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 4)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }

        }
        else if (PlayerPrefs.GetInt("level") > 20 && PlayerPrefs.GetInt("level") <= 25)
        {
            rastgele_obje = Random.Range(0, 4);

            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 4);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 5)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }
        }
        else if (PlayerPrefs.GetInt("level") > 25 && PlayerPrefs.GetInt("level") <= 30)
        {
            rastgele_obje = Random.Range(0, 5);

            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 5);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 6)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }

        }
        else if (PlayerPrefs.GetInt("level") > 30)
        {
            rastgele_obje = Random.Range(0, 6);
            if (rastgele_obje == gecicisayi)
            {


                rastgele_obje = Random.Range(0, 6);
                if (rastgele_obje == gecicisayi)
                {


                    rastgele_obje++;
                    if (rastgele_obje == 7)
                    {
                        rastgele_obje = 0;
                    }

                    gecicisayi = rastgele_obje;

                }
                else
                {
                    gecicisayi = rastgele_obje;
                }

            }
            else
            {
                gecicisayi = rastgele_obje;
            }
        }
        
    }
   
    // Update is called once per frame
    void Update () {

        for (var i = 0; i < Input.touchCount; ++i)
        {


            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                top_ilkonum = transform.position;
                dokunmak_ilkonum = new Vector3(Input.GetTouch(0).position.x, 0, 0);
            }


        }
        if (basla==1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + hiz * Time.deltaTime, transform.position.z);
            if (dokunmak==1)
            {
                if (Input.touchCount > 0)
                {
                    transform.position = new Vector3(top_ilkonum.x + (Input.GetTouch(0).position.x - dokunmak_ilkonum.x)/43, transform.position.y, transform.position.z);
                } }
            
            //transform.Translate(Vector3.up * hiz * Time.deltaTime);

        }
        if(transform.position.x>-380 || transform.position.x < -550)
        {
            transform.position = new Vector3(- 469.25f, transform.position.y, transform.position.z);
            
        }
	}
    public void olmasın()
    {
        dokunmak = 0;
        
    }
    public void dokundu()
    {
        basla = 1;
        dokunmak = 1;
        butonlar.SetActive(false);
        bestskor_objesi.SetActive(false);
        
    }
    void OnTriggerExit2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "tetik")
        {
            if (PlayerPrefs.GetInt("ses") == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(sesdosyaları[1], 1);
            }
            puan +=PlayerPrefs.GetInt("level");
            int yuzde_kaci_tamam = puan / PlayerPrefs.GetInt("level") * 4;
            yuzde_kac_ibresi.value = yuzde_kaci_tamam;
            puantexti.text = puan.ToString();
           
            if (puan / PlayerPrefs.GetInt("level") < 21)
            {
                Invoke("rastgele_" + (puan / PlayerPrefs.GetInt("level") + 5).ToString(), 0);
            }
            int gecicibest_score = PlayerPrefs.GetInt("bestskor");
            if (puan / PlayerPrefs.GetInt("level") < 25)
            {
                if (gecicibest_score < puan)
                {
                    if (gecicibest_score != 0)
                    {
                        newskor_paneli.SetActive(true);
                    }
                    PlayerPrefs.SetInt("bestskor", puan);
                }
            }
            if (puan / PlayerPrefs.GetInt("level") == 25)
            {
                PlayerPrefs.SetInt("bestskor", 0);
                level_gecildi_yazisi.text = "LEVEL " + PlayerPrefs.GetInt("level").ToString() + " PASSED";
                PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);              
                
                
                
                bolum_bitti();
                

                Time.timeScale = 0;
            }
            

        }
    }
    public void bolum_bitti()
    {
        bolumbitti_paneli.SetActive(true);
        //PlayerPrefs.SetInt("bestskor", 0);

    }
    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "engel")
        {
            if (PlayerPrefs.GetInt("ses") == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(sesdosyaları[0], 1);
            }
            Oyunsonu();
            oyunsonu_paneli.SetActive(true);
            Time.timeScale = 0;
            

        }
    }
    public void Oyunsonu()
    {
        int yuzde_kaci_tamam = puan / PlayerPrefs.GetInt("level") * 4;
        yuzdekactamam_sonuc.text = "%"+yuzde_kaci_tamam.ToString()+" COMPLETED";
    }
    public void tekraroyna()
    {
        if (PlayerPrefs.GetInt("reklam_varmı") == 0)
        {
            /// buraya reklam gelecek
        }
        if (PlayerPrefs.GetInt("level")<4)
        {
            SceneManager.LoadSceneAsync("kolay bolum");
        }
        else
        {
            SceneManager.LoadSceneAsync("zor_bolum");
        }
    }
    public void renk_random()
    {
        Color newColor_Amk = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0.5f);
        background.GetComponent<Image>().color = newColor_Amk;

        int rastgele_renk = Random.Range(0, 7);

        GameObject.Find("sol tahta").gameObject.GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
        GameObject.Find("sag tahta").gameObject.GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];

        for (int i=0;i<24;i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if(j==0|| j == 6)
                {
                    satırlar[i].transform.GetChild(j).Find("sol tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("sag tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                }
                if (j == 1 || j == 2|| j == 3|| j == 5)
                {
                    satırlar[i].transform.GetChild(j).Find("sol tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("sag tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("orta tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                }
               
                if (j == 4)
                {
                    satırlar[i].transform.GetChild(j).Find("sol tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("sag tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("orta tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("sag dik tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                    satırlar[i].transform.GetChild(j).Find("sol dik tahta").GetComponent<SpriteRenderer>().color = newColor[rastgele_renk];
                }
                

            }
        }
        

    }
   
}
