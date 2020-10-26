using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States
    {
        start,
        intro1,
        intro2,
        linksofrechts,
        links,
        rechts, 
        voordeur,
        receptie,
        voordeur2,
        schuur,
        dood,
        victory,
        commonroom,
        boven,
        kamers,
        commonroomzoeken,
        kamer001,
        kamer002,
        kamer003,
        kamer004,
        kamer005,
        kamer006,
        kamer007,
        kamer008,
        kamer002zoeken,
        kamer003zoeken,
        kamer005zoeken,
        kamer006openen,
        kamer007zoeken,
        kamer6einde,
        kamer6verstoppen,
        kamer6rennen,
        kamer6win,
        praten,
        luisteren,
        vertrekken,
        luisterenja,
        luisterennee,
        verstoppenkast,
        verstoppenprullebak,
        lab,
        glippen,
        afleiden,
        wachten,
    }

    private States currentState = States.start;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Asylum");
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "Dit is gebasseerd op een waargebeurd verhaal. " +
            "Typ de woorden in \u0022Quotes\u0022 om je pad te bepalen. " +
            "Nadat je een keuze hebt gemaakt kan je niet meer terug. " +
            "Denk er dus goed over na."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022start\u0022 om te beginnen");
    }

    void OnUserInput(string input)
    
    {
        switch (currentState)
        {
            case States.start :
                if (input == "start")
                {
                    currentState = States.intro1;
                    StartIntro1();
                }
                else if (input == "1337")
                {
                    Terminal.WriteLine("Jij bent Leet!");
                }
                else if (input == "fakka")
                {
                    Terminal.WriteLine("Fakka broer");
                }
                break;
            
            case States.intro1 :
                if (input == "verder")
                {
                    currentState = States.intro2;
                    StartIntro2();
                }
                break;
            
            case States.intro2 :
                if (input == "verder")
                {
                    currentState = States.linksofrechts;
                    StartLinksOfRechts();
                }
                break;
            
            case States.linksofrechts:
                if (input == "links")
                {
                    currentState = States.links;
                    StartLinks();
                }else if(input == "rechts")
                {
                    currentState = States.rechts;
                    StartRechts();
                }
                break;
            
            case States.rechts:
                if (input == "ja")
                {
                    currentState = States.schuur;
                    StartSchuur();
                }else if (input == "nee")
                {
                    currentState = States.voordeur;
                    StartVoordeur();
                }
                break;
            
            case States.links:
                if (input == "verder")
                {
                    currentState = States.voordeur;
                    StartVoordeur();
                }
                break;
            case States.schuur:
                if (input == "verder")
                {
                    currentState = States.dood;
                    Startdood();
                }
                break;
            case States.dood:
                if (input == "restart")
                {
                    currentState = States.start;
                    ShowMainMenu();
                }
                break;
            case States.voordeur:
                if (input == "verder")
                {
                    currentState = States.voordeur2;
                    StartVoordeur2();
                } else if (input == "receptie")
                {
                    currentState = States.receptie;
                    StartReceptie();
                }
                break;
            case States.receptie:
                if (input == "verder")
                {
                    currentState = States.victory;
                    StartVictory();
                }
                break;
            case States.victory:
                if (input == "gewonnen")
                {
                    currentState = States.start;
                    ShowMainMenu();
                }
                break;
            case States.voordeur2:
                if (input == "commonroom")
                {
                    currentState = States.commonroom;
                    StartCommonroom();
                }else if (input == "boven")
                {
                    currentState = States.boven;
                    StartBoven();
                }else if (input == "kamers")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.commonroom:
                if (input == "terug")
                {
                    currentState = States.voordeur2;
                    StartVoordeur2();
                }else if (input == "zoeken")
                {
                    currentState = States.commonroomzoeken;
                    StartCommonRoomZoeken();
                }
                break;
            case States.commonroomzoeken:
                if (input == "terug")
                {
                    currentState = States.commonroom;
                    StartCommonroom();
                }
                break;
            case States.kamers:
                if (input == "kamer 001")
                {
                    currentState = States.kamer001;
                    StartKamer001();
                }else if (input == "kamer 002")
                {
                    currentState = States.kamer002;
                    StartKamer002();
                }else if (input == "kamer 003")
                {
                    currentState = States.kamer003;
                    StartKamer003();
                }else if (input == "kamer 004")
                {
                    currentState = States.kamer004;
                    StartKamer004();
                }else if (input == "kamer 005")
                {
                    currentState = States.kamer005;
                    StartKamer005();
                }else if (input == "kamer 006")
                {
                    currentState = States.kamer006;
                    StartKamer006();
                }else if (input == "kamer 007")
                {
                    currentState = States.kamer007;
                    StartKamer007();
                }else if (input == "kamer 008")
                {
                    currentState = States.kamer008;
                    StartKamer008();
                }else if (input == "terug")
                {
                    currentState = States.voordeur2;
                    StartVoordeur2();
                }
                break;
            case States.kamer001:
                if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer002:
                if (input == "zoeken")
                {
                    currentState = States.kamer002zoeken;
                    StartKamer002Zoeken();
                }else if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer003:
                if (input == "zoeken")
                {
                    currentState = States.kamer003zoeken;
                    StartKamer003Zoeken();
                }else if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer004:
                if (input == "terug")
                {
                    currentState = States.kamers;
                        StartKamers();
                }
                break;
            case States.kamer005:
                if (input == "zoeken")
                {
                    currentState = States.kamer005zoeken;
                    StartKamer005Zoeken();
                }else if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer006:
                if (input == "9631")
                {
                    currentState = States.kamer006openen;
                    StartKamer006Openen();
                }else if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer007:
                if (input == "forceren")
                {
                    currentState = States.kamer007zoeken;
                    StartKamer007Zoeken();
                }else if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer008:
                if (input == "terug")
                {
                    currentState = States.kamers;
                    StartKamers();
                }
                break;
            case States.kamer6einde:
                if (input == "verstoppen")
                {
                    currentState = States.kamer6verstoppen;
                    StartKamer6Verstoppen();
                }else if (input == "rennen")
                {
                    currentState = States.kamer6rennen;
                    StartKamer6Rennen();
                }
                break;
            case States.kamer6verstoppen:
                if (input == "verder")
                {
                    currentState = States.kamer6win;
                    StartKamer6Win();
                }
                break;
            case States.kamer6win:
                if (input == "verder")
                {
                    currentState = States.victory;
                    StartVictory();
                }
                break;
            case States.kamer6rennen:
                if (input == "verder")
                {
                    currentState = States.dood;
                    Startdood();
                }
                break;
            case States.kamer006openen:
                if (input == "terug")
                {
                    currentState = States.kamer6einde;
                    StartKamer6Einde();
                }
                break;
            case States.kamer002zoeken:
                if (input == "terug")
                {
                    currentState = States.kamer002;
                    StartKamer002();
                }
                break;
            case States.kamer003zoeken:
                if (input == "terug")
                {
                    currentState = States.kamer003;
                    StartKamer003();
                }
                break;
            case States.kamer005zoeken:
                if (input == "terug")
                {
                    currentState = States.kamer005;
                    StartKamer005();
                }
                break;
            case States.kamer007zoeken:
                if (input == "terug")
                {
                    currentState = States.kamer007;
                    StartKamer007();
                }
                break;
            case States.boven:
                if (input == "praten")
                {
                    currentState = States.praten;
                    StartPraten();
                }else if (input == "terug")
                {
                    currentState = States.voordeur2;
                    StartVoordeur2();
                }
                break;
            case States.praten:
                if (input == "luisteren")
                {
                    currentState = States.luisteren;
                    StartLuisteren();
                }else if (input == "vertrekken")
                {
                    currentState = States.boven;
                    StartBoven();
                }
                break;
            case States.luisteren:
                if (input == "ja")
                {
                    currentState = States.luisterenja;
                    StartLuisterenJa();
;                }else if (input == "nee")
                {
                    currentState = States.luisterennee;
                    StartLuisterenNee();
                }
                break;
            case States.luisterenja:
                if (input == "prullebak")
                {
                    currentState = States.verstoppenprullebak;
                    StartVerstoppenPrulleBak();
                }else if (input == "kast")
                {
                    currentState = States.verstoppenkast;
                    StartVerstoppenKast();
                }
                break;
            case States.luisterennee:
                if (input == "verder")
                {
                    currentState = States.dood;
                    Startdood();
                }
                break;
            case States.verstoppenprullebak:
                if (input == "verder")
                {
                    currentState = States.dood;
                    Startdood();
                }
                break;
            case States.verstoppenkast:
                if (input == "verder")
            {
                currentState = States.lab;
                StartLab();
            }
                break;
            case States.lab:
                if (input == "glippen")
                {
                    currentState = States.glippen;
                    StartGlippen();
                }else if (input == "afleiden")
                {
                    currentState = States.afleiden;
                    StartAfleiden();
                }else if (input == "wachten")
                {
                    currentState = States.wachten;
                    StartWachten();
                }
                break;
            case States.glippen:
                if (input == "verder")
                {
                    currentState = States.dood;
                    Startdood();
                }
                break;
            case States.afleiden:
                if (input == "verder")
                {
                    currentState = States.victory;
                    StartVictory();
                }
                break;
            case States.wachten:
                if (input == "afleiden")
                {
                    currentState = States.afleiden;
                    StartAfleiden();
                }else if (input == "glippen")
                {
                    currentState = States.wachten;
                    StartWachten();
                }

                break;




        }
    }

    void StartIntro1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je speelt als Dave Blake, een nieuwsreporter voor het AD. " +
            "Je werd gevraagd om een verslag te schrijven over het asylum. " +
            "Voordat je uberhaupt naar binnen bent hoor je al schreewende mensen."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartIntro2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je loopt met een slecht gevoel naar de voordeur van het gebouw. " +
             "Er zijn vele verhalen over dit asylum, mensen die als levende experimenten worden gebruik, " +
             "Doctoren die vermoord worden door de inmates en het gaat zo maar door."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartLinksOfRechts()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je loopt naar de voordeur van het gebouw. " +
             "Je klopt aan maar er word niet open gedaan. " +
             "Wanneer je probeert de deur open te doen " +
             "Merk je dat hij niet open gaat en op slot zit. " +
             "Je besluit om even rond het gebouw te lopen"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Ga je \u0022links\u0022 of ga je \u0022rechts\u0022 om?");
    }

    void StartLinks()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit links om te lopen. Wanneer je langs de linker kant " +
            "van het gebouw loopt loop je langs een raam. Je kijkt door het " +
            "raam en ziet iets dat lijkt op een persoon maar omdat het donker " +
            "is kan je hem niet goed zien. Je leunt in om het beter te kunnen zien, " +
            "maar het lijkt wel alsof het verdween terwijl je knipperde. " +
            "De linker kant van het gebouw loopt dood, je besluit om weer " +
            "terug te lopen naar de voordeur."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartRechts()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om rechts langs het gebouw te lopen. " +
            "Je loopt tot dat je een klein soort schuurtje ziet, " +
            "de deur van dit schuurtje staat open. Naast dit schuurtje " +
            "is er niets aan de rechterkant van het gebouw."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Ga je naar binnen?");
        Terminal.WriteLine("\u0022Ja\u0022 of \u0022Nee\u0022");
    }

    void StartVoordeur()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om terug naar de voordeur te lopen, " +
            "wanneer je terug bent bij de voordeur merk je dat hij " +
            "ineens open is en dat je naar binnen kan lopen. Je loopt " +
            "naar de \u0022receptie\u0022. Het is amper een receptie te " +
            "noemen. Er is niemand aanwezig, je kijkt om je heen en merkt " +
            "dat het gebouw helemaal aan het vervallen is aan de binnenkant. "+
            "Het is een wonder dat het nog staat. Aangezien niemand naar de " +
            "receptie komt ga je zelf maar op onderzoek uit, opzoek naar iets " +
            "van bewijs dat dit gebouw gesloten moet worden."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }
    
    void StartVoordeur2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
        (
            "Je kijkt om je heen, wat je kan zien zijn 3 paden. " +
            "Je kan links om naar de \u0022commonroom\u0022 te gaan, je kan rechts om " +
            "richting de \u0022kamers\u0022 van de inmates te gaan of je kan verder om naar " +
            " \u0022boven\u0022 te gaan. Waar wil je heen?"
        );
        Terminal.WriteLine("");
        Terminal.WriteLine("Wil je naar de\u0022commonroom\u0022, naar \u0022boven\u0022 of naar de \u0022kamers\u0022?");
    }

    void StartSchuur()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je loopt de schuur binnen. Er is veel gereedschap aanwezig, " +
            "Echter is dat niet het meest opvallende. Er loop een trap naar " +
            "beneden. Het lijkt er op alsof deze schuur een kelder heeft. " +
            "Je loopt de trap naar beneden en gaat de hoek om. Zodra je de hoek omloopt " +
            "loop je tegen een soort reuze mens aan, een persoon die langer is dan 2 meter," +
            "het lijkt ook alsof zijn huid aan hem vast is genaaid. Voordat je iets kan " +
            "zeggen pakt hij je bij de nek en draait hij deze om."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je bent Dood");
        Terminal.WriteLine("Typ \u0022verder\u0022");
    }

    void Startdood()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Dankje voor het spelen van mijn tekst adventure game, " +
            "Gemaakt door Maric-Alexei Brouwer voor het vak Gamedevelepment."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022restart\u0022 om opnieuw te beginnen");
    }

    void StartReceptie()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je zoekt achter de receptie in de lades voor iets van " +
            "bewijs tegen het asylum. Je vind een soort log waarin je " +
            "allemaal vreselijke testen in kan terug lezen. Je besluit om dit " +
            "mee te nemen als bewijs tegen het asylum"
        );
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "Typ \u0022verder\u0022 om door te gaan."
            );
    }

    void StartVictory()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je hebt bewijs kunnen vinden tegen het asylum. " +
            "Je laat je bevinding zien aan de autoriteiten en " +
            "schrijft een artikel voor in de krant. Door jou hulp " +
            "is er genoeg bewijs om het asylum te kunnen sluiten."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "Je hebt gewonnen!, typ \u0022gewonnen\u0022 om verder te gaan."
            );
    }

    void StartCommonroom()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je komt in de commonroom, Er zitten hier wat inmates te staren naar een " +
            "TV met een storing. Ze kijken niet jou kant op, het lijkt net alsof ze je niet " +
            "hebben zien binnen komen. De inmates zien er een soort zombie achtig uit, " +
            "alsof ze levend dood zijn. Verder is hier op het eerst blik niet veel te zien,"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "Vanaf nu kan je in alle kamers \u0022zoeken\u0022. Typ dit als jij denkt dat deze " +
            "kamer iets verbergt dat je op het eerste blik niet kan zien. Zeker niet allekamers " +
            "zullen iets hebben wat je kan zoeken. Probeer het maar eens in deze kamer."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om weer naar de receptie te gaan.");
    }

    void StartCommonRoomZoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je doorzoekt de commonroom, je loopt een beetje rondom de kamer. " +
            "Wanneer je voor de TV loopt beginnen de inmates naar je te signaleren om " +
            "voor het beeld vandaan te gaan. Er is niets te vinden in de common room"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022");
    }

    void StartBoven()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je gaat de Trap op en ziet dat het leid naar een geheim lab. " +
            "Zodra je daar aan komt zie je een inmate, hij zegt dat hij met je wilt praten"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("\u0022Praten\u0022            \u0022terug\u0022");
    }

    void StartPraten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Hij zegt dat hij weet waarom jij hier bent en dat hij je graag wilt vertellen " +
            "wat hier aan de hand is. Maar kan je hem wel vertrouwen? Hij ziet er net uit als al " +
            "die andere gekken."
            );
        Terminal.WriteLine("\u0022luisteren\u0022                \u0022Vertrekken\u0022");
    }

    void StartLuisteren()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Hij zegt dat hij hier in dit asylum is gekomen door valse beschuldigingen, en dat hij " +
            "toen is gebruik als test subject voor het testen van bepaalde aanpassingen die ze hier " +
            "onderzoeken en dat hij er daarom zo uit ziet. Hij wilt graag dat je deze tent laat sluiten. " +
            "Hij zegt dat er test resultaten zijn verborgen in het lab en dat als je deze hebt dat je dat " +
            "bekent kan maken. Dat zal er voor zorgen dat het asylum zal moeten sluiten. Alleen weet hij niet " +
            "waar deze zijn. Je zult ze waarschijnlijk vinden in het kantoor van het lab. Het probleem is alleen " +
            "dat hier vaak de onderzoekers bezig zijn. Hij zegt dat hij ze wilt afleiden zodat jij die documenten " +
            "snel kan pakken."
        );
        Terminal.WriteLine("");
        Terminal.WriteLine("Het klinkt als een gevaarlijk plan. \u0022ja\u0022 of \u0022nee\u0022?");
    }

    void StartLuisterenJa()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om akoord te gaan met zijn idee en gaat proberen de lab resluitaten te stelen. " +
            "Je gaat verder het lab in terwijl je zo stil mogelijk probeert te lopen hoor je voet stappen op je af " +
            "komen en beseft dat je je snel moet verstoppen. Ze zijn er waarschijnlijk achter gekomen dat " +
            "jij hier bent. Ze zijn opzoek naar je."
        );
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "Je moet je snel verstoppen maar waar? Je ziet een \u0022kast\u0022 waar je je in kan verstoppen " +
            "of je kan je verstoppen in een \u0022prullebak\u0022."
            );
    }

    void StartVerstoppenKast()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit je te verstoppen in een kast, je gaat er snel in en ziet een reus langs " +
            "je lopen. maar hij opent niet de kast hij stop wel even om in de prullebak te kijken. " +
            "De kust is weer veilig."
            );
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartVerstoppenPrulleBak()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je verstop je in de prullebak. Je ziet de reus jou kant op lopen. " +
            "Je ziet dat de reus zo langs de kast loopt waar je je in had kunnen " +
            "verstoppen. Zodra hij dichterbij komt ga je gouw met je hoofd verder de " +
            "bak in om je zo goed mogelijk te verstoppen, maar helaas heeft hij je kunnen " +
            "vinden en vermoord hij je."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je bent dood. Typ \u0022verder\u0022 om door te gaan");
    }

    void StartLuisterenNee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit niet naar hem te luisteren, het is nou eenmaal een gek. " +
            "Zodra je je wilt omdraaien om weg te lopen word de inmate gek omdat je niet " +
            "naar hem wilt luisteren. Hij rent op je af een steek je neer. Hij schreeuw: " +
            "LUISTER LUISTER LUISTER, STERF STERF STERF"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je bent dood. Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartLab()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je loopt voorzichtig weer richting het lab, je singaleert de inmate om de reus af te lijden " +
            "zodat jij naar binnen kan glippen en de documenten kan pakken, de reus loopt richting de " +
            "inmate, maar tot je schrik draait de reus de nek van de inmate binnen een seconde om en loopt al " +
            "weer terug richting jou. Je ziet de documenten voor je liggen en pakt ze snel. Alleen nu zit je  " +
            "vast in de kamer met de reus die de weg blokkeert. Je kan je verstoppen " +
            "en wachten totdat hij weg gaat, ook kan je geluid maken hopen dat je dan sneller weg kan rennen dan hem. " +
            "Misschien is het een slim idee om langs hem proberen te glippen wanneer hij het niet door heeft."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine
            (
            "\u0022glippen\u0022        \u0022afleiden\u0022        \u0022wachten\u0022"
            );
    }

    void StartGlippen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om lang de reus te glippen, je probeert zo stil mogelijk langs hem te gaan. " +
            "Helaas werkt dit niet zoals je gedacht had, voordat je uberhaupt een meter langs hem bent" +
            " heeft hij je al door en pak hij je beet. Das pech nek weg."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je bent dood. Typ \u0022verder\u0022 om door te gaan");
    }

    void StartAfleiden()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om hem af te leiden, je zit een kopje en gooit hem langs " +
            "de reus, tot je verassing heeft dit gewerkt. Je kan nu makkelijk langs hem lopen richting " +
            "de uitgang."
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    void StartWachten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je besluit om te wachten. Dit had je kunnen wachten, maar zelfs na 15 minuten wachten " +
            "is hij nog geen centimeter verschoven. Wil je hem proberen af te leiden of ga je er langs " +
            "proberen te glippen?"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("\u0022afleiden\u0022            \u0022wachten\u0022");
    }

    void StartKamers()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je gaat en hal in met een aantal kamers, er zit een man " +
            "op een rolstoel in de hal de schreeuwen. Hij schreeuwt: GA WEG GA WEG GA WEG" +
            "JE HOORT HIER NIET WEG WEG WEG. Zou hij het tegen jou hebben?"
            );
        Terminal.WriteLine
            (
            "\u0022kamer 001\u0022            \u0022kamer 002\u0022            \u0022kamer 003\u0022" +
            "            \u0022kamer 004\u0022            \u0022kamer 005\u0022            \u0022kamer 006\u0022" +
            "            \u0022kamer 007\u0022            \u0022kamer 008\u0022"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je kan nu in iedere kamer\u0022zoeken\u0022 typ dit wanneer denkt dat er iets verborgen is in die kamer.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022. om terug naar de receptie te gaan");
    }

    void StartKamer001()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer is geblokkert aan de andere kant");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer002()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer deur staat open maar er is niemand aanwezig");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer003()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer zit dicht maar hij zit niet opslot. Je doet de deur open en zit dat er een man aanwezig is");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer004()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer zit dicht en wilt ook niet open.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer005()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer is open en je kan naar binnen. Er ligt een inmate schreeuwend op zijn bed.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer006()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Op deze kamer zit een cijfer slot van 4 cijfers");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer007()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze kamer zit dicht maar de deur ziet er slecht uit. misschien dat je hem kan open kan \u0022forceren\u0022");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer008()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Uit deze kamer komen flink hard bonken, alsof iemand met zijn hoofd tegen een muur aan slaat. De Deur zit op slot");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }

    void StartKamer002Zoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vind een briefje met het getal 9 erop.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer003Zoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vind een briefje met het getal 6 erop.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer005Zoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je vind een briefje met het getal 3 erop.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer007Zoeken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je forceert de deur open, dit maakte een luideknal en moet iemand gehoort hebben" +
            "Je vind het laatste deel van het briefje met het getal 1 erop, " +
            "ook staat er dat de getallen van groot naar klein moeten worden geplaatst");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }
    
    void StartKamer006Openen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je hebt Het slot kunnen openen met de code die je hebt gevonden in de  andere kamers, " +
            "wanneer je binnen komt zie je niet een reden waarom deze kamer op slot zat zonder dat " +
            "iemand er in zit. Je kijkt een beetje rond de kamer en vind een dag dagboek van één " +
            "van de inmates. In dat dag boek staat een verslag over het experiment die de doctoren hier " +
            "doen op de inmates. Dit is genoeg om het asylum te kunnen sluiten"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022terug\u0022 om terug te gaan.");
    }

    void StartKamer6Einde()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Zodra je uit de kamer stapt hoor de de voet stappen van een groot iemand op je af komen. " +
            "Je moet je ergens verstoppen, maar waar? Misschien is het beter om gewoon te rennen?"
            );
        Terminal.WriteLine("");
        Terminal.WriteLine(" Ga je je \u0022verstoppen\u0022 in 1 van de kamers? Of ga je \u0022rennen\u0022?");
    }

    void StartKamer6Verstoppen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je rent snel in kamer 005, je hoort de man steeds dichterbij komen. " +
            "Al snel is het gestomp gestopt en hoor je de reus weer weg rennen. " +
            "Hij kwam waarschijnlijk op de knal af rennen die je maakte toen je kamer 007 " +
            "open forceerde. Het is maar goed dat je hebt besloten om je te verstoppen want " +
            "deze man kan je niet uit rennen."
        );
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan");
    }

    void StartKamer6Win()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Na dat je het geren van de reus niet meer kan horen besluit je " +
            "om snel naar de uitgang te rennen."
            );
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan");
    }

    void StartKamer6Rennen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine
            (
            "Je rent zo snel als je kan, wanneer je achter je kijkt zie je de reus op je af komen rennen, " +
            "het is echt een monster een soort van naakte man zonder iets op zijn lichaam, overal wonder van " +
            "experimenten. Het is net een gemaakte super mensen. Hij komt steeds dichterbij maar voordat " +
            "je het door hebt heeft hij je te pakken gekregen. Hij pakt je vast, gooit je op de grond en " +
            "stampt je hoofd kapot met zijn voet."
        );
        Terminal.WriteLine("");
        Terminal.WriteLine("Je bent dood");
        Terminal.WriteLine("Typ \u0022verder\u0022 om door te gaan.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
    }
}