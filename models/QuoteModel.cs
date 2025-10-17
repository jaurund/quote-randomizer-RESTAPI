
namespace QuoteModel;

using System;


public class QuoteList
{
    public List<string> Quotes { get; set; } = new List<string>();
}

public class QuoteRandomizer
{
    public required string[] quotes =
    {
        "På alle gravsteiner bør det stå: «Han gjorde så godt han kunne.»",
        "Ikke vær et ettall på jorda. Bry deg om flokken din.",
        "Det verste er ikke når kroppen dør, men når grunnen til å stå opp om morgenen dør.",
        "Vi lever i det tryggeste sekund i historien, på det tryggeste sted på kloden. Nyt det!",
        "Oppskrift på Det gode liv: En teskje kjærlighet, tolv drømmer, drysse på litt snillhet, lange friminutt, en liter plikt, to kilo softis.",
        "Fremskrittspartiets eple vokser ikke på kunnskapens tre",
        "Vi forventer 100% sikkerhet, null faenskap, full lykke. Slik blir livet en kronisk skuffelse.",
        "Skulle vi tro forsiden av VG og Dagbladet, er gjennomsnittlig levealder i Norge 7,3 år.",
        "Vi må skape rause, trygge flokker hvor mennesket får erfare at tilhørighet er bedre enn å pusse navle i enerom.",
        "Når 30 000 besøker Alternativmessen for å lære om hypnose via navlen og orgasme i tårekanalen, er her fare på ferde.",
        "Kroppen er et klassesamfunn. Her er aristokratiske og proletære organer. Ryggen er simpel. Hjertet er adelig.",
        "En god resept på et godt liv er å gi litt mer faen.",
        "Alle har et medfødt menneskeverd som man ikke skal tulle med.",
        "Hvis man aldri får prøvd seg i livets faresoner, hvordan skal en da bli «fit for fight» i jungelen?",
        "Prestasjon er bra, men du må være din egen målestokk og unngå overdose.",
        "Er du glad i livet, så er du glad i barn.",
        "Jeg tror vi gjør noe ufattelig dumt hvis jakten på det beste blir vår målestokk.",
        "Ta døden tilbake, den er en dypt personlig eiendel. Har du vært et myndig menneske på jorden så skal du for faen føre også i siste dans.",
        "Hvis døden ikke var, ville livet ditt, følelsene, forholdene, forelskelsene, alt ville vært uutholdelig. At livet er avgrenset, gir det potens.",
        "Når vi tar pynt og masker av, og lander i livet, så oppdager vi at sånn er livet med flekker og feil, med svakhet og styrke, med avmakt og håp, med krise og seire. Sånn er det nakne livet.",
        "Livet er ikke perfekt, uten feil og fandenskap. Vi må godta oss selv og hverandre som medfødt feilvare.",
        "Å leva, det er å elska det beste DI sjel fikk nå. Ikke det beste Northug fikk nå.",
        "Bare ved å leke og herje med sannheten, bare ved å tenke fantastisk kan vi åpne for radikal ny erkjennelse.",
        "Jesus og Muhammed viser at den åndsmakten som heter håp er sterkere enn atommakt og lykkepiller.",
        "Mennesket er menneskets helsekilde.",
        "Jeg har kunnet gå på oppdagelsesreise nær døden.",
        "En fin resept for livet er å ikke hele tida legge målene for kropp, livsstil, samliv, kariere så langt borte at du aldri når dem.",
        "Vi er blitt verdens rikeste land, og har vondt av det. Vi danser rundt gullkalven og brenner ut.",
        "Jeg er forelsket i det vanlige mennesket.",
        "Mot er den dyd som kan stimulere de milliarder udrømte drømmer, utenkte tanker, ikke-følte følelser, ikke-sk",
        "Det er onsdagslivet som fortjener begeistring og onsdagsmennesket som fortjener hyllest.Rettferdighet er den største kapital et land kan ha.",
        "Rettferdighet er den største kapital et land kan ha.",
        "Den modige kritikk er mer nødvendig enn noen gang, fordi makten sminker seg med kommunikasjonsrådgivere og designerord.",
        "Det er bare en måte å bli trygg på: Vi må inngå samliv med fare. Vi må godta at det forferdelige kan skje. Hvis vi forventer null risiko og total beskyttelse, blir vi evig redde. Absolutt trygghet er umulig.",
        "Universitetene og høyskolene skal ikke utdanne forvaltere av virkelighet, eller gamle leksikon. De skal stimulere til annerledestenkning, oppfinnsomhet og tro på egen hjernekraft.",
        "«Her skal vi gi dere retten og motet til å finne deres egen sannhet og drømme andre drømmer», bør være motto for alle høyskoler og universiteter i Norge.",
        "Velferdsstaten er en skjør bygning. Den kan gå i stykker. Vi må forsvare den mot jeg-partiet som vil ødelegge vi-samfunnet."
    };

    public string GetRandomQuote()
    {
        Random random = new Random();

        // Generate a random index within the array's bounds
        int randomIndex = random.Next(0, quotes.Length);

        // Retrieve the string at the random index
        string randomQuote = quotes[randomIndex];
        Console.WriteLine($"Randomly selected quote: {randomQuote}");
        return randomQuote;
    }

    // Display the randomly selected string
}