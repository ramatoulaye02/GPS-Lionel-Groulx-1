using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Contraintes : MonoBehaviour
{
    public List<string> CreerListeLocauxAileD()
    {
        int[] tabLocauxetage1 = new int[27];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 101;

        int[] tabLocauxetage2 = new int[42];
        for (int i = 0; i < tabLocauxetage2.Length; i++)
            tabLocauxetage2[i] = i + 201;

        int[] tabLocauxetage3 = new int[29];
        for (int i = 0; i < tabLocauxetage3.Length; i++)
            tabLocauxetage3[i] = i + 301;

        int[] tabLocauxetage4 = new int[37];
        for (int i = 0; i < tabLocauxetage4.Length; i++)
            tabLocauxetage4[i] = i + 401;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage1);
        locaux.AddRange(tabLocauxetage2);
        locaux.AddRange(tabLocauxetage3);
        locaux.AddRange(tabLocauxetage4);

        List<string> locauxD = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });

        return locauxD;
    }

    public List<string> CreerListeLocauxAileL()
    {
        int[] tabLocauxetage0 = new int[16];
        for (int i = 0; i < tabLocauxetage0.Length; i++)
            tabLocauxetage0[i] = i + 6;

        int[] tabLocauxetage2 = new int[32];
        for (int i = 0; i < tabLocauxetage2.Length; i++)
            tabLocauxetage2[i] = i + 201;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage0);
        locaux.AddRange(tabLocauxetage2);

        List<string> locauxL = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxL;
    }

    public List<string> CreerListeLocauxAileF()
    {
        int[] tabLocauxetage1 = new int[22];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 101;

        int[] tabLocauxetage2 = new int[12];
        for (int i = 0; i < tabLocauxetage2.Length; i++)
            tabLocauxetage2[i] = i + 201;

        int[] tabLocauxetage3 = new int[26];
        for (int i = 0; i < tabLocauxetage3.Length; i++)
            tabLocauxetage3[i] = i + 301;

        int[] tabLocauxetage4 = new int[14];
        for (int i = 0; i < tabLocauxetage4.Length; i++)
            tabLocauxetage4[i] = i + 401;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage1);
        locaux.AddRange(tabLocauxetage2);
        locaux.AddRange(tabLocauxetage3);
        locaux.AddRange(tabLocauxetage4);

        List<string> locauxF = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });

        return locauxF;
    }

    public List<string> CreerListeLocauxAileN()
    {
        int[] tabLocauxetage1 = new int[11];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 104;

        int[] tabLocauxetage2 = new int[14];
        for (int i = 0; i < tabLocauxetage2.Length; i++)
            tabLocauxetage2[i] = i + 201;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage1);
        locaux.AddRange(tabLocauxetage2);

        List<string> locauxN = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxN;
    }

    public List<string> CreerListeLocauxAileE()
    {
        int[] tabLocauxetage0 = new int[19];
        for (int i = 0; i < tabLocauxetage0.Length; i++)
            tabLocauxetage0[i] = i + 3;

        List<int> locaux = new List<int>();
        locaux.AddRange(tabLocauxetage0);

        List<string> locauxE = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxE;
    }

    public List<string> CreerListeLocauxAileK()
    {
        int[] tabLocauxetage0 = new int[11];
        for (int i = 0; i < tabLocauxetage0.Length; i++)
            tabLocauxetage0[i] = i + 2;

        List<int> locaux = new List<int>();
        locaux.AddRange(tabLocauxetage0);

        List<string> locauxK = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxK;
    }

    public List<string> CreerListeLocauxAileC()
    {
        int[] tabLocauxetage0 = new int[44];
        for (int i = 0; i < tabLocauxetage0.Length; i++)
            tabLocauxetage0[i] = i + 2;

        int[] tabLocauxetage1 = new int[20];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 102;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage0);
        locaux.AddRange(tabLocauxetage1);

        List<string> locauxC = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxC;
    }

    public List<string> CreerListeLocauxAileM()
    {
        int[] tabLocauxetage1 = new int[37];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 102;

        int[] tabLocauxetage0 = new int[46];
        for (int i = 0; i < tabLocauxetage0.Length; i++)
            tabLocauxetage0[i] = i + 2;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage0);
        locaux.AddRange(tabLocauxetage1);

        List<string> locauxM = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return locauxM;
    }

    public List<string> CreerListeLocauxAileS()
    {
        int[] tabLocauxetage1 = new int[38];
        for (int i = 0; i < tabLocauxetage1.Length; i++)
            tabLocauxetage1[i] = i + 101;

        int[] tabLocauxetage2 = new int[50];
        for (int i = 0; i < tabLocauxetage2.Length; i++)
            tabLocauxetage2[i] = i + 201;

        int[] tabLocauxetage3 = new int[50];
        for (int i = 0; i < tabLocauxetage3.Length; i++)
            tabLocauxetage3[i] = i + 301;

        int[] tabLocauxetage4 = new int[43];
        for (int i = 0; i < tabLocauxetage4.Length; i++)
            tabLocauxetage4[i] = i + 401;

        int[] tabLocauxetage5 = new int[52];
        for (int i = 0; i < tabLocauxetage5.Length; i++)
            tabLocauxetage5[i] = i + 501;

        List<int> locaux = new List<int>();

        locaux.AddRange(tabLocauxetage1);
        locaux.AddRange(tabLocauxetage2);
        locaux.AddRange(tabLocauxetage3);
        locaux.AddRange(tabLocauxetage4);
        locaux.AddRange(tabLocauxetage5);

        List<string> locauxS = locaux.ConvertAll<string>(delegate(int i) { return i.ToString(); });

        return locauxS;
    }

    public TMP_Dropdown dropdown1,
        dropdown2,
        dropdown3,
        dropdownLocal1,
        dropdownLocal2,
        dropdownAile,
        dropdownAileEtage,
        dropdownToilettes,
        dropdownEtages;

    public Button button,
        bouttonSuivant;

    public TMP_Text text1,
        text2,
        text3,
        text4,
        textToilette,
        textEtage,
        textLocal,
        textAile,
        textContraintes1,
        textContraintes2,
        textContraintes3,
        textContraintes4,
        textContraintes5,
        textContraintes6,
        textContraintes7,
        textContraintes8,
        textContraintes9,
        messageContraintes,
        textAileEtage;

    public static string choixDropdown2,
        choixDropdown3,
        choixNbToilettes,
        choixAile,
        choixEtageDeAile,
        choixAileLocal,
        choixNbLocal;

    private string localChoisi;


    void SetObjects(bool etat1, bool etat2, bool etat3, bool etat4, bool etat5, bool etat6, bool etat7, bool etat8)
    {
        text1.gameObject.SetActive(etat1);
        dropdown1.gameObject.SetActive(etat2);
        text2.gameObject.SetActive(etat3);
        text3.gameObject.SetActive(etat4);
        dropdown2.gameObject.SetActive(etat5);
        dropdown3.gameObject.SetActive(etat6);
        text4.gameObject.SetActive(etat7);
        button.gameObject.SetActive(etat8);
    }

    private void MakeObjectsDisappear()
    {
        SetObjects(false, false, false, false, false, false, false, false);
    }

    private void SetSpecificObjects(bool etat1, bool etat2, bool etat3, bool etat4, bool etat5, bool etat6, bool etat7,
        bool etat8, bool etat9, bool etat10, bool etat11)
    {
        dropdownLocal1.gameObject.SetActive(etat1);
        dropdownLocal2.gameObject.SetActive(etat2);
        textLocal.gameObject.SetActive(etat3);
        dropdownAile.gameObject.SetActive(etat4);
        dropdownAileEtage.gameObject.SetActive(etat5);
        textAileEtage.gameObject.SetActive(etat6);
        textAile.gameObject.SetActive(etat7);
        dropdownEtages.gameObject.SetActive(etat8);
        textEtage.gameObject.SetActive(etat9);
        dropdownToilettes.gameObject.SetActive(etat10);
        textToilette.gameObject.SetActive(etat11);
    }

    private void ResetDropdown(TMP_Dropdown dropd1)
    {
        dropd1.value = 0;
    }

    private void ResetAllDropdowns()
    {
        ResetDropdown(dropdown1);
        ResetDropdown(dropdown2);
        ResetDropdown(dropdown3);
        ResetDropdown(dropdownLocal1);
        ResetDropdown(dropdownLocal2);
        ResetDropdown(dropdownAile);
        ResetDropdown(dropdownEtages);
        ResetDropdown(dropdownAileEtage);
        ResetDropdown(dropdownToilettes);
    }


    public void CreateDropdown(List<string> items, TMP_Dropdown dropdown)
    {
        dropdown.ClearOptions();

        foreach (var item in items) dropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });
    }

    public List<string> CreerListeDropdown3()
    {
        var items = new List<string>();
        items.Add(" ");
        items.Add(" la cafétéria");
        items.Add("le carrefour étudiant");
        items.Add(" toilette/s");
        items.Add("un local spécifique");
        items.Add("une aile spécifique");
        items.Add("la bibliothèque");
        var contraintes = phrases;
        foreach (var phrase in contraintes)
        {
            if (phrase.Contains("par l'aile"))
                items.Remove("une aile spécifique");
            if (phrase.Contains(" toilette/s"))
                items.Remove(" toilette/s");
            if (phrase.Contains("la bibliothèque"))
                items.Remove("la bibliothèque");
            if (phrase.Contains("le carrefour étudiant"))
                items.Remove("le carrefour étudiant");
            if (phrase.Contains(" la cafétéria"))
                items.Remove(" la cafétéria");
        }
        return items;
    }

    public List<string> CreerListeDropdown2()
    {
        var items = new List<string>();
        items.Add("");
        items.Add("passer");
        items.Add("ne pas passer");
        return items;
    }

    public List<string> CreerListeDropdownToilette()
    {
        var tabNbToilettes = new int[20];
        for (var i = 0; i < tabNbToilettes.Length; i++)
            tabNbToilettes[i] = i + 1;

        var nbToilettes = new List<int>();

        nbToilettes.AddRange(tabNbToilettes);

        var items = nbToilettes.ConvertAll<string>(delegate(int i) { return i.ToString(); });
        return items;
    }

    public List<string> CreerListeDropdownAiles()
    {
        var items = new List<string>();
        items.Add(" ");
        items.Add("D");
        items.Add("L");
        items.Add("F");
        items.Add("N");
        items.Add("K");
        items.Add("C");
        items.Add("S");
        items.Add("M");
        items.Add("E");
        return items;
    }

    public List<string> CreerListeDropdownEtages()
    {
        var items = new List<string>();
        items.Add("");
        items.Add("0");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        items.Add("4");
        return items;
    }
    
    public École CollègeLio { get; set; }


    private void Start()
    {
        List<Node> points = GénérerÉcole.GetListePoints(FileReadingTools.LireFichierTxt("OutsideData.txt"));
        CollègeLio = new École("Nodes.txt",points[15]);
        
        SetObjects(true, true, false, false, false, false, false, false);
        SetSpecificObjects(false, false, false, false, false, false, false, false, false, false, false);
        bouttonSuivant.gameObject.SetActive(false);

        dropdown1.onValueChanged.AddListener(delegate { Dropdown1ValueChangedHappened(dropdown1); });

        CreateDropdown(CreerListeDropdown2(), dropdown2);
        CreateDropdown(CreerListeDropdown3(), dropdown3);
        CreateDropdown(CreerListeDropdownToilette(), dropdownToilettes);
        CreateDropdown(CreerListeDropdownAiles(), dropdownAile);
        CreateDropdown(CreerListeDropdownEtages(), dropdownEtages);
        CreateDropdown(CreerListeDropdownAiles(), dropdownLocal1);


        dropdown2.onValueChanged.AddListener(delegate { Dropdown2ValueChangedHappened(dropdown2); });
        dropdown3.onValueChanged.AddListener(delegate { Dropdown3ValueChangedHappened(dropdown3); });
        button.onClick.AddListener(ComportementBoutton);
        bouttonSuivant.onClick.AddListener(ComportementBouttonSuivant);
        
        AnalyserContraintes();

    }

    
    public static List<string> phrases = new List<string>(9);
    public string phrase;

    public static PathfindingNode depart;
    public static PathfindingNode arrivee;
    private static List<PathfindingNode> NodesÀÉviter, NodesInévitables;
    private static PathfindingNode ChosenNode;
    private static List<Func<Boolean>> contraintes;
    
    private void CreerPhrase()
    {
        if (choixDropdown3 == " la cafétéria" || choixDropdown3 == "le carrefour étudiant" ||
            choixDropdown3 == "la bibliothèque")
            phrase = $"Je voudrais {choixDropdown2} par {choixDropdown3}";
        if (choixDropdown3 == "un local spécifique")
            phrase = $"Je voudrais {choixDropdown2} par le local {choixAileLocal}{choixNbLocal}";
        if (choixDropdown3 == "une aile spécifique")
            phrase = $"Je voudrais {choixDropdown2} par l'aile {choixAile}{choixEtageDeAile}00";
        if (choixDropdown2 == "passer" && choixDropdown3 == " toilette/s")
            phrase = $"Je voudrais passer par {choixNbToilettes} {choixDropdown3}";
        if (choixDropdown2 == "ne pas passer" && choixDropdown3 == " toilette/s")
            phrase = $"Je voudrais éviter des toilettes";
        
        phrases.Add(phrase);
    }

    private void AfficherPhrase()
    {
        List<TMP_Text> textes = new List<TMP_Text>();
        textes.Add(textContraintes1);
        textes.Add(textContraintes2);
        textes.Add(textContraintes3);
        textes.Add(textContraintes4);
        textes.Add(textContraintes5);
        textes.Add(textContraintes6);
        textes.Add(textContraintes7);
        textes.Add(textContraintes8);
        textes.Add(textContraintes9);

        for (int i = 0; i < phrases.Count; i++)
        {
            textes[i].text = phrases[i];
        }
    }

    private void AfficherMessage()
    {
        messageContraintes.text = "Vous avez atteint la limite de 9 contraintes";
    }

    public void ComportementBoutton()
    {
        bouttonSuivant.gameObject.SetActive(true);
        
        if (phrases.Count == 9)
        {
            MakeObjectsDisappear(); // sauf la liste et le bouton suivant
            SetSpecificObjects(false,false,false,false,false,false,false,false,false,false,false);
            AfficherMessage(); 
        }
        else
        {
            CreerPhrase();
            CreateDropdown(CreerListeDropdown3(),dropdown3);
            ResetAllDropdowns();
            SetObjects(false, false, true, true, true, true, true, false);
            SetSpecificObjects(false, false, false, false, false, false, false, false, false, false, false);
            AfficherPhrase();
        }
    }

    public void ComportementBouttonSuivant()
    {
        SceneManager.LoadScene(5);
    }

    void Dropdown1ValueChangedHappened(TMP_Dropdown dropdown)
    {
        var newSelectedIndex = dropdown.value;
        if (newSelectedIndex == 1)
            SetObjects(false, false, true, true, true, false, true, false);
        if (newSelectedIndex == 2)
            SceneManager.LoadScene(5);
    }

    void Dropdown2ValueChangedHappened(TMP_Dropdown dropdown)
    {
        SetObjects(false, false, true, true, true, true, true, false);
        var newSelectedIndex = dropdown.value;
        choixDropdown2 = dropdown.options[newSelectedIndex].text;
    }

    void Dropdown3ValueChangedHappened(TMP_Dropdown dropdown)
    {
        var indexChoisi = dropdown.value;
        choixDropdown3 = dropdown.options[indexChoisi].text;
        if (choixDropdown3 == " la cafétéria" || choixDropdown3=="le carrefour étudiant" || choixDropdown3=="la bibliothèque")
            SetObjects(false, false, true, true, true, true, true, true);
        if (choixDropdown3== " toilette/s" && choixDropdown2 == "passer")
        {
            MakeObjectsDisappear();
            SetSpecificObjects(false, false, false, false, false, false, false, false, false, true, true);
            dropdownToilettes.onValueChanged.AddListener(delegate
            {
                DropdownToiletteValueChangedHappened(dropdownToilettes);
            });
        }
        else
        {
            SetObjects(false, false, true, true, true, true, true, true);
        }

        if (choixDropdown3== "un local spécifique")
        {
            MakeObjectsDisappear();
            SetSpecificObjects(true, false, true, false, false, false, false, false, false, false, false);
            dropdownLocal1.onValueChanged.AddListener(delegate { DropdownLocal1ValueChangedHappened(dropdownLocal1); });
        }
        
        if (choixDropdown3 == "une aile spécifique")
        {
            MakeObjectsDisappear();
            SetSpecificObjects(false, false, false, true, false, false, true, false, false, false, false);
            dropdownAile.onValueChanged.AddListener(delegate { DropdownAileValueChangedHappened(dropdownAile); });
        }
    }


    void DropdownToiletteValueChangedHappened(TMP_Dropdown dropdown)
    {
        var newSelectedIndex = dropdown.value;
        choixNbToilettes = dropdown.options[newSelectedIndex].text;
        SetObjects(false, false, false, false, false, false, false, true);
    }
    

    void DropdownAileValueChangedHappened(TMP_Dropdown dropdown)
    {
        var newSelectedIndex = dropdown.value;
        choixAile = dropdown.options[newSelectedIndex].text;
        if (choixAile == "K" || choixAile == "E" || choixAile == "M")
        {
            SetSpecificObjects(false, false, false, true, false, false, true, false, false, false, false);
            SetObjects(false, false, false, false, false, false, false, true);
            choixEtageDeAile = "0";
        }
        else
        {
            SetSpecificObjects(false, false, false, true, true, true, true, false, false, false, false);
            if (choixAile == "D" || choixAile == "F")
                CreateDropdown(CreerListeEtageAileDEtF(), dropdownAileEtage);
            if (choixAile == "L")
                CreateDropdown(CreerListeEtageAileL(), dropdownAileEtage);
            if (choixAile == "N")
                CreateDropdown(CreerListeEtageAileN(), dropdownAileEtage);
            if (choixAile == "C")
                CreateDropdown(CreerListeEtageAileC(), dropdownAileEtage);
            if (choixAile == "S")
                CreateDropdown(CreerListeEtageAileS(), dropdownAileEtage);

            dropdownAileEtage.onValueChanged.AddListener(delegate
            {
                DropdownAileEtageValueChangedHappened(dropdownAileEtage);
            });
        }
    }

    void DropdownAileEtageValueChangedHappened(TMP_Dropdown dropdown)
    {
        var newSelectedIndex = dropdown.value;
        choixEtageDeAile = dropdown.options[newSelectedIndex].text;
        SetObjects(false, false, false, false, false, false, false, true);
    }

    void DropdownLocal1ValueChangedHappened(TMP_Dropdown dropdown)
    {
        SetSpecificObjects(true, true, true, false, false, false, false, false, false, false, false);
        var selectedIndex = dropdown.value;
        if (selectedIndex == 1)
            CreateDropdown(CreerListeLocauxAileD(), dropdownLocal2);
        if (selectedIndex == 2)
            CreateDropdown(CreerListeLocauxAileL(), dropdownLocal2);
        if (selectedIndex == 3)
            CreateDropdown(CreerListeLocauxAileF(), dropdownLocal2);
        if (selectedIndex == 4)
            CreateDropdown(CreerListeLocauxAileN(), dropdownLocal2);
        if (selectedIndex == 5)
            CreateDropdown(CreerListeLocauxAileK(), dropdownLocal2);
        if (selectedIndex == 6)
            CreateDropdown(CreerListeLocauxAileC(), dropdownLocal2);
        if (selectedIndex == 7)
            CreateDropdown(CreerListeLocauxAileS(), dropdownLocal2);
        if (selectedIndex == 8)
            CreateDropdown(CreerListeLocauxAileM(), dropdownLocal2);
        if (selectedIndex == 9)
            CreateDropdown(CreerListeLocauxAileE(), dropdownLocal2);

        choixAileLocal = dropdown.options[selectedIndex].text;
        dropdownLocal2.onValueChanged.AddListener(delegate { DropdownLocal2ValueChangedHappened(dropdownLocal2); });
    }


    public void DropdownLocal2ValueChangedHappened(TMP_Dropdown dropdown)
    {
        var newSelectedIndex = dropdown.value;
        choixNbLocal = dropdown.options[newSelectedIndex].text;
        SetObjects(false, false, false, false, false, false, false, true);
    }

    public List<string> CreerListeEtageAileDEtF()
    {
        var etages = new List<string>();
        etages.Add("");
        etages.Add("1");
        etages.Add("2");
        etages.Add("3");
        etages.Add("4");
        return etages;
    }

    public List<string> CreerListeEtageAileS()
    {
        var etages = new List<string>();
        etages.Add("");
        etages.Add("1");
        etages.Add("2");
        etages.Add("3");
        etages.Add("4");
        etages.Add("5");
        return etages;
    }

    public List<string> CreerListeEtageAileL()
    {
        var etages = new List<string>();
        etages.Add("");
        etages.Add("0");
        etages.Add("2");
        return etages;
    }

    public List<string> CreerListeEtageAileC()
    {
        var etages = new List<string>();
        etages.Add("");
        etages.Add("0");
        etages.Add("1");
        return etages;
    }

    public List<string> CreerListeEtageAileN()
    {
        var etages = new List<string>();
        etages.Add("");
        etages.Add("1");
        etages.Add("2");
        return etages;
    }

    private static bool ContientPasPasser(string contrainte)
    {
        if (contrainte.Contains("pas passer"))
            return true;
        else
        {
            return false;
        }
    }

    public static Pathfinder pathfinder { get; set; }


    public void AnalyserContraintes()
    {
        if (phrases.Count == 0)
        {
            pathfinder = new AStarPathfinder(depart, GetNode(MenuChoixDestination.Destination,CollègeLio));
        }
        
        for (int i = 0; i < phrases.Count; i++)
        {
            if (phrases[i].Contains("pas passer"))
            { 
                CreerListeNodesAeviter(phrases,CollègeLio);
                // si il ya juste des pas passer
                if (phrases.TrueForAll(ContientPasPasser))
                {
                    pathfinder = new AStarPathfinder(depart, arrivee, NodesÀÉviter);
                    NodesÀÉviter.Clear();
                }
            }

            if (!(phrases[i].Contains("pas ")))
            {
                if (phrases.Count == 1 && phrases[0].Contains("local spécifique"))
                {
                    string localACroiser = $"{choixAileLocal}{choixNbLocal}";
                    ChosenNode = GetNode(localACroiser, CollègeLio);
                    pathfinder = new AStarPathfinder(depart, arrivee, ChosenNode);
                }

                if (phrases.Count > 1 && phrases[i].Contains("pas passer") &&
                    phrases.Where(x => !(x.Contains("pas "))).Count() == 1)
                {
                    CreerListeNodesAeviter(phrases, CollègeLio);
                    pathfinder =  new AStarPathfinder(depart, arrivee, NodesÀÉviter, ChosenNode);
                }
            }
        }
    }
    

    public static void CreerListeNodesAeviter(List<string> phrases, École école)
    {

        for (int i = 0; i < phrases.Count; i++)
        {
            if (phrases[i].Contains("pas passer"))
            {
                //if (phrases[i].Contains("étage spécifique"))
                //{
                   // FloorGraph floor = école.Floors[int.Parse(choixEtage)];
                    //NodesÀÉviter.AddRange(floor.Nodes);
                //}
                if (phrases[i].Contains("aile spécifique"))
                {
                    FloorGraph floor = école.Floors[int.Parse(choixEtageDeAile)];
                    foreach (var nodes in floor.Nodes)
                    {
                        if (nodes.Nom[1] == choixAile[0])
                            NodesÀÉviter.Add(nodes);
                    }
                }

                if (phrases[i].Contains("toilette/s"))
                {
                    foreach (var floors in école.Floors)
                    {
                        foreach (var nodes in floors.Nodes)
                        {
                            if (nodes.Nom == "Toilettes")
                                NodesÀÉviter.Add(nodes);
                        }
                    }
                }

                if (phrases[i].Contains("local spécifique"))
                {
                    string localAEviter = $"{choixAileLocal}{choixNbLocal}";
                    NodesÀÉviter.Add(GetNode(localAEviter, école));
                }
            }
        }
    }

    public static PathfindingNode GetNode(string destination,École école)
    {
        FloorGraph floor = école.Floors[GetÉtage(destination)];
        PathfindingNode noeud = floor.Nodes[0];
        foreach (var node in floor.Nodes)
        {
            if (!EstLocal(destination))
            {
                if (GénérerÉcole.ContientUn(destination,node))
                    noeud = node;
            }
            else
            {
                if (GénérerÉcole.ContientUn(destination[0].ToString(),node))
                {
                    if (destination.Contains("À"))
                    {
                        string[] nombres = node.Nom.Split('À');
                        if (int.Parse(destination.Remove(0)) >= int.Parse(nombres[0]) ||
                            int.Parse(destination.Remove(0)) >= int.Parse(nombres[1]))
                        {
                            noeud = node;
                        }
                        else
                        {
                            if (GénérerÉcole.ContientUn(destination, node)) ;
                            noeud = node;
                        }
                    }
                   
                }
            }
        }

        return noeud;
    }

    public static int GetÉtage(string destination)
    {
        int etage;
        if (EstLocal(destination))
            etage = int.Parse(destination[1].ToString());
        else
        {
            if (destination[0] == 'B')
                etage = 3;
            else
            {
                etage = 0;
            }
        }
        return etage;
    }

    public static bool EstLocal(string destination)
    {
        if(destination[1]!='a')
            return MenuChoixDestination.AILES.Contains(destination[0]);
        return false;
    }

    public static bool PasseParEtage(List<PathfindingNode> path, Étage étage)
    {
        bool passeParEtage = false;
        foreach (var node in path)
        {
            if (node.Niveau == étage)
                passeParEtage = true;
        }

        return passeParEtage;
    }
    public static bool PasseParAile(List<PathfindingNode> path, Aile aile)
    {
        bool passeParAile = false;
        foreach (var node in path)
        {
            if (node.Aile == aile)
                passeParAile = true;
        }

        return passeParAile;
    }

    public static bool PasseParToilette(List<PathfindingNode> path, int nbToilettes)
    {
        bool passeParToilette = false;
        if (path.Where(x => (x.Nom.Contains("Toilettes"))).Count() == nbToilettes)
        {
            passeParToilette = true;
        }

        return passeParToilette;

    }
}