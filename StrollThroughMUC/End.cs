using System;
using System.Collections.Generic;

namespace StrollThroughMUC
{
    public class EndGoodEverythingGood
    {
        public static void EndOfMUC()
        {
            Console.WriteLine("OPTIONALES ENDE: Wie angekündigt können deine Taten Folgen habe. Nachdem du unschuldige Bewohner Münchens umgebracht hast musst du im Gericht aussagen:");
            Console.WriteLine(Munich.Pati.Name + ", Sie wurden angeklagt aufgrund von mehrfachem Mord an Personen an den unterschiedlichsten Plätzen in München. Was wollen sie zu ihrer Verteidung sagen?");
            Console.WriteLine("Du hast die Optionen 1:Nix, 2:Es ist nicht so wie es scheint!, 3:Ich kann das erklären, 4:Passiert halt");
            string Aussage1 = Console.ReadLine();
            switch (Aussage1)
            {
                case("1"):
                Console.WriteLine("- Lebenslange Freiheitsstrafe");
                break;
                
                case("2"):
                Console.WriteLine("- Also wenn es nicht so ist wie es scheint, dann möchte ich eine genau ERklärung bekommen, wie zum Teufel man das falschen deuten kann.");
                Console.WriteLine("Du hast die Optionen 1:lange Geschichte, 2:Kurze Geschichte");
                Case2();
                break;

                case("3"):
                Console.WriteLine("- Auf die Erklärung bin ich aber mal gespannt");
                Console.WriteLine("Du hast die Optionen 1:lange Erklärung, 2:Kurze Erklärung");
                Case3();
                break;

                case("4"):
                Console.WriteLine("- Ja so was kann leider echt schnell ausversehen passieren... Ich würde sagen wir vergessen diese Geschichte und das nächste mal bitte vorher ankündigen. Wir wollen nicht, dass das eventuell jemand zurück angreift und Ihnen passiert etwas. Haben Sie noch einen schönen Tag!!");
                Console.WriteLine("ENDE");
                break;

                default:
                Console.WriteLine("Falsch eingetippt");
                EndOfMUC();
                break;
            }
        }

        public static void Case2()
        {
            string Aussage2 = Console.ReadLine();
            switch(Aussage2)
            {
                case("1"):
                Console.WriteLine("Deine Erklärung lautete: Auf den Weg in die Arbeit habe ich meine neuen Pillen genommen. Diese wurden mir von einem Arzt verschrieben. Allerdings ist das schon einige Jahre her. Ich habe total vergessen, dass ich sie hätte nehmen sollen. Als ich heute aufgewacht bin war mir etwas schwummrig. Jedoch hatte ich keine Medizin im Haus, abgesehen von den alten verschriebenen Pillen. Nun ja, ...es war Sonntag und kein Geschäft hatte offen,... und ja ich muss am Sonntag arbeiten ich arme Sau. Währen ich unterwegs war hatte ich unglaubliche Halluzinationen und dachte ich werde angegriffen. Ich habe aus meinem Rucksack und meiner Umgebung genommen was ich konnte und damit gekämpft. Ich schwöre auf mein Leben, dass das nicht ich war. So bin ich nicht.");
                Console.WriteLine("- LOL Nice try. Ab in den Knast");
                break;

                case("2"):
                Console.WriteLine("Deine Erklärung lautete: Alle Leute haben sich umgebracht als ich bei ihnen war. Nicht ich war das. Beispielsweise ist der Surfer beim Surfen ins Wasser gefallen und hat sich den Kopf aufgeschlagen... Ich wollte doch nur helfen.");
                Console.WriteLine("- Das haben Sie sich aber eine nette Ausrede rausgekramt. So schnell kommen sie da nicht raus. Der Fall wird nächste Woche fortgeführt. Ich habe erstmal Hunger Ciao.");
                break;

                default:
                Console.WriteLine("Falsch eingetippt");
                Case2();
                break;
            }

        }

        public static void Case3()
        {
            string Aussage2 = Console.ReadLine();
            switch(Aussage2)
            {
                case("1"):
                Console.WriteLine("Deine Erklärung lautete: ähhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhähähähähähhhhähhhhhhhhhhhhhhhhhhhh  oh gott ich kann das doch nicht erklären");
                Console.WriteLine("- Keine Sorge, ein Gefängnis hat nicht so schlechtes Essen");
                break;

                case("2"):
                Console.WriteLine("Deine Erklärunglautete: Das war ein Schauspiel im öffentlich Raum.");
                Console.WriteLine("- Warum sagen Sie das nicht sofort?? Warum sitzen wir hier überhaupt noch!! Oh man ich hasse meinen Job");
                break;

                default:
                Console.WriteLine("Falsch eingetippt");
                Case3();
                break;

            }
            
        }
        
    }
}