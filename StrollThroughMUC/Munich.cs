using System;
using System.Collections.Generic;

namespace StrollThroughMUC
{
    public class Munich{

        //Create Places
            public static Place Perlach = new Place 
            {
                PlaceDescription="Perlach: Willkommen in Perlach. Hier wohnt nur die Creme de la Creme. Ein Stadtteil der besonderen Art. Fühl dich wie zu Hause und schau dich ein wenig um!  ", 
                PlaceName = "Perlach"
            };
            public static Place Odeonsplatz = new Place 
            { 
                PlaceDescription="Odeonsplatz: Leute im Anzug, Studenten oder Shoppingqueens laufen hier rum. Aber aufpassen! Nicht, dass du hier ausversehen in einen Markenladen rennt. Bleib lieber bei Primark. ", 
                PlaceName = "Odeonsplatz" 
            };
            public static Place Stachus = new Place 
            { 
                PlaceDescription="Stachus: Wer Touristen mit Shoppingtüten sucht, der muss hier vorbeischauen. Der Treffpunkt jedes Mingabewohners. Im Kino aber lieber nicht am Popcorn ersticken..", 
                PlaceName = "Stachus" 
            };
            public static Place Hauptbahnhof = new Place 
            { 
                PlaceDescription="Hauptbahnhof: Auf gehts nach Berlin! Oder doch lieber direkt nach Rom mit dem Nachtzug? Geiles Essen gibts auch.", 
                PlaceName = "Hauptbahnhof" 
            };
            public static Place Eisbach = new Place 
            { 
                PlaceDescription="Eisbach: Wer braucht schon Meer, wenns die Eisbachwelle gibt! Im Sommer tümmelt sich die Elite München im Englischen Garten und genießt die Sonne. Wem das Wasser nicht zu kalt ist sprint zur Erfrischung in den eiskalten Eisbach.", 
                PlaceName = "Eisbach" 
            };            
            public static Place CurrentPlace = Perlach;
            public static void BuildMunich()
            {
            //Create Map
            Perlach.Direction.Add("n", Odeonsplatz);
            Perlach.Direction.Add("w", Hauptbahnhof);
            Odeonsplatz.Direction.Add("e", Eisbach);
            Odeonsplatz.Direction.Add("w", Stachus);
            Odeonsplatz.Direction.Add("s", Perlach);
            Stachus.Direction.Add("e", Odeonsplatz);
            Stachus.Direction.Add("s", Hauptbahnhof);
            Hauptbahnhof.Direction.Add("e", Perlach);
            Hauptbahnhof.Direction.Add("n", Stachus);
            Eisbach.Direction.Add("w", Odeonsplatz);

            //Fill Inventories of Characters
            Pati.PlayerInventory.Add(Pfefferspray);
            Penner.PlayerInventory.Add(Müsliriegel);
            Touri.PlayerInventory.Add(Fotoapparat);
            Tussi.PlayerInventory.Add(Kreditkarte);
            Surfer.PlayerInventory.Add(Surfboard);

            //Fill Inventories of Places
            Perlach.PlaceInventory.Add(PrimarkTuete);
            Odeonsplatz.PlaceInventory.Add(GucciTasche);       
            Stachus.PlaceInventory.Add(McDonaldsPommes);
            Stachus.PlaceInventory.Add(BISS);
            Hauptbahnhof.PlaceInventory.Add(Doener);
            Eisbach.PlaceInventory.Add(Wasser);

            //Add Players to the Places
            Perlach.PlayersInPlace.Add(Pati);
            Odeonsplatz.PlayersInPlace.Add(Tussi);       
            Stachus.PlayersInPlace.Add(Touri);
            Hauptbahnhof.PlayersInPlace.Add(Penner);
            Eisbach.PlayersInPlace.Add(Surfer);

            // Evil List
            AllEvil.SmartEnemyList.Add(Penner);
            AllEvil.SmartEnemyList.Add(Surfer);
            AllEvil.SmartEnemyList.Add(Touri);
            AllEvil.SmartEnemyList.Add(Tussi);

            // All Places
            AllPlaces.AllPlacesList.Add(Munich.Eisbach);
            AllPlaces.AllPlacesList.Add(Munich.Odeonsplatz);
            AllPlaces.AllPlacesList.Add(Munich.Hauptbahnhof);
            AllPlaces.AllPlacesList.Add(Munich.Perlach);
            AllPlaces.AllPlacesList.Add(Munich.Stachus);
        }
        //public class MUCItems{
            //Items of Places
            public static Item PrimarkTuete= new Item{
                ItemName ="Primark-Tüte",
            };
            public static Item Doener= new Item{
                ItemName ="Döner",
            };
            public static Item McDonaldsPommes= new Item{
                ItemName ="McDonald-Pommes vom Boden",
            };
            public static Item BISS = new Item{
                ItemName ="BISS-Zeitung",
            };

            public static Item GucciTasche= new Item{
                ItemName ="Gucci-Tasche",
            };
            public static Item Wasser= new Item{
                ItemName ="Wasser",
            };

            //Items of Characters
            public static Item Pfefferspray= new Item{
                ItemName ="Pfefferspray",
            };
            public static Item Stift= new Item{
                ItemName ="Stift",
            };
            public static Item Müsliriegel= new Item{
                ItemName ="Müsliriegel",
            };
            public static Item Surfboard= new Item{
                ItemName ="Surfboard",
            };
            public static Item Kreditkarte= new Item{
                ItemName ="Kreditkarte",
            };
            public static Item Fotoapparat= new Item{
                ItemName ="Fotoapparat",
            };

            //Item with a List of Evil Characters
            public static Item AllEvil= new Item{
                ItemName ="AllEvil",
            };

            //Item with a List of all Places
            public static Item AllPlaces= new Item{
                ItemName ="AllPlaces",
            };
            
            //Create all Players
            public static MainCharacter Pati= new MainCharacter{
                Name ="Pati",
                Selfdescription= "Hey ich bin du, du bist ich. Ich werde mit dir München erkunden und wir, bzw. ich werde von Ort zu Ort wandern.",
                ConversationSentence= "ich Selbstgespräche liebe. Spread Self-love"
            };
            public static SmartEnemy Penner= new SmartEnemy{
                Name ="Penner",
                Selfdescription = "Mein Name ist Ben. Als meine Frau mich verlassen hat und ich zur gleich Zeit meinen Job verlor, bin ich in ein großes Loch gefallen. Ich wüschte das Leben würde mir eine zweite Chance geben.",
                Healthpoints= 1,
                ConversationSentence="es mir echt scheiße geht, weil ich auf der Straße wohne. Hast du zufällig paar Münzen? Bräuchte mal wieder meine tägliche Dosis."
            };
            public static SmartEnemy Touri= new SmartEnemy{
                Name ="Touri",
                Selfdescription = "Ich bin ein Touri. Mehr brauchst du nicht wissen. Wer bist du eigendlich??",
                Healthpoints = 1,
                ConversationSentence="es mir mega geht. Sehr coole Stadt, leckeres Essen. Kannst du ein Foto von mir machen?"
            };
            public static SmartEnemy Tussi= new SmartEnemy{
                Name ="Tussi", 
                Selfdescription="Mein Name ist Lisa und ich komme aus einem Ärztehaus. Zurzeit gehe ich auf eine Privatschule und nach meinem Abi werde ich nach England gehen und dort Medizin studieren.",
                Healthpoints = 1,
                ConversationSentence= "mein Vater mir wieder nur 200 Euro zum shoppen mitgegeben hat! Kannst du dir das vorstellen? Mit so wenig Geld werde ich doch nie die passende Tasche finden. DU bräuchtest aber auch mal nen neuen Kleiderschrank, so wie du ausschaust..."
            };
            public static SmartEnemy Surfer= new SmartEnemy{
                Name ="Surfer",
                Selfdescription = "Ich bin Alex. Zurzeit studiere ich BWL an der LMU und in meiner Freizeit findet man mich mit meinem Board im Wasser. Die Jahreszeit ist mir dabei egal.",
                Healthpoints = 1,
                ConversationSentence = "es mir fabelhaft geht. Schau dir mal diese geile Welle an. Wer braucht schon ans Meer gehen, wenn man in der eigenen Stadt Wellenreiten gehen kann!"
            };
        //}
    }
}